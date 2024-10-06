using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.TokenDtos;
using HomeDecorAPI.Application.DTOs.UserDtos;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.BadRequestException;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Services
{
    public sealed class AuthenticationService : IAuthenticationService {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly IAuthenticationService _authenticationService;
        private User _user;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthenticationService(IHttpContextAccessor httpContextAccessor , IAuthenticationService authenticationService, IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration)
        {
            _mapper = mapper;
            _signInManager = signInManager;
            _userManager = userManager;
            _configuration = configuration;
            _authenticationService = authenticationService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IdentityResult> RegisterUserAsync(UserForRegistrationDto userForRegistration) {
            var user = _mapper.Map<User>(userForRegistration);

            var result = await _userManager.CreateAsync(user, userForRegistration.Password);

            if (result.Succeeded) {
                await _userManager.AddToRolesAsync(user, userForRegistration.Roles);
            }

            return result;
        }

        public async Task<UserDto?> LoginAsync(UserForLoginDto userForLoginDto) {
            var user = await _userManager.FindByEmailAsync(userForLoginDto.UserName)
                       ?? await _userManager.FindByNameAsync(userForLoginDto.UserName);

            if (user == null) {
                return null;
            }
            _user = user;
            var result = await _signInManager.PasswordSignInAsync(user.UserName!, userForLoginDto.Password, userForLoginDto.RememberMe, lockoutOnFailure: false);
            if(result.Succeeded) {
                var userDto = _mapper.Map<UserDto>(user);
                var roles = await _userManager.GetRolesAsync(user);
                userDto.Roles = roles;

                return userDto;
            }
            
            return null;
        }


        public async Task<TokenDto> CreateToken(bool populateExp) {
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);
            var refreshToken = GenerateRefreshToken();

            _user.RefreshToken = refreshToken;

            if (populateExp)
                _user.RefreshTokenExpiryTime = DateTime.Now.AddDays(1);

            await _userManager.UpdateAsync(_user);

            var accessToken = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            return new TokenDto(accessToken, refreshToken);
        }

        private SigningCredentials GetSigningCredentials() {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var key = Encoding.UTF8.GetBytes(jwtSettings["secretKey"]);
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private async Task<List<Claim>> GetClaims() {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, _user.UserName!),
                new Claim(ClaimTypes.Email, _user.Email!), 
                new Claim(ClaimTypes.NameIdentifier, _user.Id!)
            };

            //claims.Add(new Claim("DisplayName", _user.DisplayName));

            var roles = await _userManager.GetRolesAsync(_user);
            foreach (var role in roles) {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims) {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var tokenOptions = new JwtSecurityToken
            (
                issuer: jwtSettings["validIssuer"],
                audience: jwtSettings["validAudience"],
                claims: claims,
                expires: DateTime.Now.AddDays(Convert.ToDouble(jwtSettings["expires"])),
                signingCredentials: signingCredentials
            );
            return tokenOptions;
        }

        private string GenerateRefreshToken() {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create()) {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        private ClaimsPrincipal GetPrincipalFromExpiredToken(string token) {
            var jwtSettings = _configuration.GetSection("JwtSettings");

            var tokenValidationParameters = new TokenValidationParameters {
                ValidateAudience = true,
                ValidateIssuer = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(jwtSettings["secretKey"])),
                ValidateLifetime = true,
                ValidIssuer = jwtSettings["validIssuer"],
                ValidAudience = jwtSettings["validAudience"]
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out
        securityToken);

            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null ||
        !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256,
                StringComparison.InvariantCultureIgnoreCase)) {
                throw new SecurityTokenException("Invalid token");
            }

            return principal;
        }

        public async Task<TokenDto> RefreshToken(TokenDto tokenDto) {
            var principal = GetPrincipalFromExpiredToken(tokenDto.AccessToken);
            var user = await _userManager.FindByNameAsync(principal.Identity.Name);
            if (user == null || user.RefreshToken != tokenDto.RefreshToken ||
            user.RefreshTokenExpiryTime <= DateTime.Now)
                throw new RefreshTokenBadRequest();
            _user = user;
            return await CreateToken(populateExp: false);
        }

        public async Task<IdentityResult> ChangePasswordAsync(ChangePasswordDto changePasswordDto) {

            if (changePasswordDto.CurrentPassword == changePasswordDto.NewPassword) {
                return IdentityResult.Failed(new IdentityError { Description = "New password must be different from the current password." });
            }
            var user = await _userManager.FindByNameAsync(changePasswordDto.Username);

            if(user == null) {
                throw new UserNotFoundException($"Username {changePasswordDto.Username} not found in the system.");
            }

            if (changePasswordDto.Email != user.Email) {
                throw new InvalidOperationException("The provided email does not match the user's email.");
            }

            var isCurrentPassword = await _userManager.CheckPasswordAsync(user, changePasswordDto.CurrentPassword);

            if (!isCurrentPassword) {
                return IdentityResult.Failed(new IdentityError { Description = "Current password is incorrect." });
            }

            var changePasswordResult = await _userManager.ChangePasswordAsync(user, changePasswordDto.CurrentPassword, changePasswordDto.NewPassword);

            return changePasswordResult;
        }


        public async Task LogoutUserAsync() {
           
            var userName = _httpContextAccessor.HttpContext.User.Identity.Name; 

            if (string.IsNullOrEmpty(userName)) {
                throw new InvalidOperationException("Không tìm thấy người dùng nào đang đăng nhập.");
            }

            
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null) {
                throw new UserNotFoundException($"Người dùng {userName} không tồn tại.");
            }

            
            user.RefreshToken = null;
            user.RefreshTokenExpiryTime = null;

            var result = await _userManager.UpdateAsync(user);

            if (!result.Succeeded) {
                // Cân nhắc ghi log nếu bạn có hệ thống log.
                throw new InvalidOperationException("Không thể cập nhật thông tin người dùng trong quá trình đăng xuất.");
            }

            // Lưu thay đổi vào cơ sở dữ liệu
            await _repositoryManager.SaveChangesAsync();
        }

    }
}
