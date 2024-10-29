using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.TokenDtos;
using HomeDecorAPI.Application.DTOs.UserDtos;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.BadRequestException;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using HomeDecorAPI.Domain.Exceptions.UnauthorizedException;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace HomeDecorAPI.Application.Services {
    public sealed class AuthenticationService : IAuthenticationService {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;
        private User _user;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserRepository _userRepository;
        private readonly ILogger<AuthenticationService> _logger;
 

        public AuthenticationService(IHttpContextAccessor httpContextAccessor, 
                                    ILogger<AuthenticationService> logger,
                                    IMapper mapper,
                                    UserManager<User> userManager,
                                    SignInManager<User> signInManager,
                                    IConfiguration configuration,
                                    IUserRepository userRepository
                                    
                                    )
        {
            _mapper = mapper;
            _signInManager = signInManager;
            _userManager = userManager;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _userRepository = userRepository;
            _logger = logger;
        }

        public async Task<IdentityResult> RegisterUserAsync(UserForRegistrationDto userForRegistration) {

            _logger.LogInformation("Bắt đầu sử lý thông tin đăng kí người dùng mới trong hệ thống.");
            var user = _mapper.Map<User>(userForRegistration);

            _logger.LogInformation("Tạo người dùng mới với Username và Password mà người dùng cung cấp.");
            var result = await _userManager.CreateAsync(user, userForRegistration.Password);

            if (result.Succeeded) {
                _logger.LogInformation("Người dùng đăng kí thành công thêm các Role cho người dùng.");
                 await _userManager.AddToRolesAsync(user, userForRegistration.Roles);
            }else {
                _logger.LogError("Thông tin đăng kí của người dùng không hợp lệ.");
                throw new RegisterUserException();
            }

            return result;
        }

        public async Task<UserDto> LoginAsync(UserForLoginDto userForLoginDto) {
            _logger.LogInformation("Bắt đầu sử lý xác thực thông tin đăng nhập");
            var user = await _userManager.FindByEmailAsync(userForLoginDto.UserName)
                       ?? await _userManager.FindByNameAsync(userForLoginDto.UserName);

            if (user == null) {
                _logger.LogError("Không tìm thấy thông tin người dùng trong database.");
                throw new UserNotFoundException();
            }

            _logger.LogInformation($"Đã tìm thấy người dùng trong hệ thống với ID: {user.Id}");
            _user = user;

            _logger.LogInformation($"Xác thực mật khẩu người dùng cung cấp.");
            var result = await _signInManager.PasswordSignInAsync(user.UserName!, userForLoginDto.Password, userForLoginDto.RememberMe, lockoutOnFailure: false);
            if(result.Succeeded) {
                _logger.LogInformation("Người dùng đăng nhập thành công.");
                var userDto = _mapper.Map<UserDto>(user);
                var roles = await _userManager.GetRolesAsync(user);
                userDto.Roles = roles;
                return userDto;
            }

            _logger.LogError("Đăng nhập không thành công! Username hoặc Password không chính xác.");
            throw new LoginException();
        }

        public async Task<UserDto> LogintAdminAsync(UserForLoginDto userForLoginDto) {
            _logger.LogInformation("Xác thực thông tin đăng nhập của Admin.");

            var admin = await _userManager.FindByNameAsync(userForLoginDto.UserName) ??
                await _userManager.FindByEmailAsync(userForLoginDto.UserName);

            if(admin == null) {
                _logger.LogError("Không tìm thấy thông tin của tài khoảng Admin trong hệ thống.");
                throw new UserNotFoundException();
            }

            var result = await _signInManager.PasswordSignInAsync(admin, userForLoginDto.Password, userForLoginDto.RememberMe, lockoutOnFailure: false);
            if(!result.Succeeded) {
                _logger.LogError("Thông tin đăng nhập không chính xác! Mật khẩu không chính sác.");
                throw new LoginBadRequest("Thông tin đăng nhập không chính xác! Sai mật khẩu.");
            }

            _logger.LogInformation("Thông tin đăng nhập chính xác! Đăng nhập thành công.");
            var isAdmin = await _userManager.IsInRoleAsync(admin, "Admin");

            if(!isAdmin) {
                _logger.LogError("Đăng nhập không thành công tài khoản không có quyền truy đăng nhập vào trang hiện tại.");
                throw new AccessDeniedException();
            }

            _logger.LogInformation("Lấy thông tim Admin sau khi đã xác thực thành công.");
            _user = admin;
            var adminDto = _mapper.Map<UserDto>(admin);
            var roles = await _userManager.GetRolesAsync(admin);
            adminDto.Roles = roles;
            _logger.LogInformation("Admin đăng nhập thành công.");
            return adminDto;
        }

        public async Task<TokenDto> CreateToken(bool populateExp) {
            _logger.LogInformation("Bắt đầu lấy thông tin để tạo Token.");
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);
            var refreshToken = GenerateRefreshToken();

            _user.RefreshToken = refreshToken;

            if (populateExp)
                _user.RefreshTokenExpiryTime = DateTime.Now.AddDays(Convert.ToDouble(jwtSettings["RefreshTokenExpiryDays"]));
            await _userManager.UpdateAsync(_user);

            var accessToken = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            return new TokenDto(accessToken, refreshToken);
        }

        private SigningCredentials GetSigningCredentials() {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var key = Encoding.UTF8.GetBytes(jwtSettings["SecurityKey"]!);
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private async Task<List<Claim>> GetClaims() {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, _user.Firstname! + _user.Lastname),
                new Claim(ClaimTypes.Email, _user.Email!), 
                new Claim(ClaimTypes.NameIdentifier, _user.Id!)
            };

            //claims.Add(new Claim("DisplayName", _user.DisplayName));
            claims.Add(new Claim("UserId", _user.Id));
            claims.Add(new Claim("Firstname", _user.Firstname));
            claims.Add(new Claim("Lastname", _user.Lastname));

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
                issuer: jwtSettings["ValidIssuer"],
                audience: jwtSettings["ValidAudience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["TokenExpiryMinutes"])),
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
                    Encoding.UTF8.GetBytes(jwtSettings["SecurityKey"]!)),
                ValidateLifetime = false,
                ValidIssuer = jwtSettings["ValidIssuer"],
                ValidAudience = jwtSettings["ValidAudience"]
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            ClaimsPrincipal principal;

            try {
                principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
            } catch (Exception) {
                throw new SecurityTokenException("Invalid token");
            }

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
            var userId = principal.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId))
                throw new RefreshTokenBadRequest();
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null || user.RefreshToken != tokenDto.RefreshToken ||
            user.RefreshTokenExpiryTime <= DateTime.Now)
                throw new RefreshTokenExpiredTimeException();
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
            try {
                var userId = _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userId)) {
                    _logger.LogWarning("Logout attempt failed: No authenticated user found");
                    throw new UnauthorizedAccessException("No authenticated user found");
                }

                _logger.LogInformation($"Logout initiated for user ID: {userId}");

                var user = await _userManager.FindByIdAsync(userId);
                if (user == null) {
                    _logger.LogWarning($"Logout failed: User with ID {userId} not found in the database");
                    throw new InvalidOperationException($"User with ID {userId} not found");
                }

                user.RefreshToken = null;
                user.RefreshTokenExpiryTime = null;
                var result = await _userManager.UpdateAsync(user);
                if (!result.Succeeded) {
                    _logger.LogError($"Failed to update user {userId} during logout. Errors: {string.Join(", ", result.Errors.Select(e => e.Description))}");
                    throw new InvalidOperationException("Failed to update user information during logout");
                }

                await _userRepository.SaveChangesAsync();
                _logger.LogInformation($"User {userId} logged out successfully");

                await _signInManager.SignOutAsync();
                _logger.LogInformation($"SignInManager.SignOutAsync completed for user {userId}");
            } catch (UnauthorizedAccessException ex) {
                _logger.LogError($"Unauthorized access during logout: {ex.Message}");
                throw;
            } catch (InvalidOperationException ex) {
                _logger.LogError($"Invalid operation during logout: {ex.Message}");
                throw;
            } catch (Exception ex) {
                _logger.LogError($"Unexpected error during logout: {ex.Message}");
                throw new InvalidOperationException("An unexpected error occurred during logout", ex);
            }
        }

    }
}
