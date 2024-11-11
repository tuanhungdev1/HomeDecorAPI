using HomeDecorAPI.Application.DTOs.TokenDtos;
using HomeDecorAPI.Application.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using HomeDecorAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts
{
    public interface IAuthenticationService {
        Task<IdentityResult> RegisterUserAsync(UserForRegistrationDto userForRegistration);
        Task<UserDto> LoginAsync(UserForLoginDto userForLoginDto);
        Task<UserDto> LogintAdminAsync(UserForLoginDto userForLoginDto);
        Task<TokenDto> CreateToken(bool populateExp);
        Task<IdentityResult> ChangePasswordAsync(ChangePasswordDto changePasswordDto);
        Task LogoutUserAsync();
        Task<TokenDto> RefreshToken(TokenDto tokenDto);
        Task<bool> IsUsernameAvailable(string username);
        Task<bool> IsEmailAvailable(string email);
    }
}
