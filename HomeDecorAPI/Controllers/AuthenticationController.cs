using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.ActionFilters;

using HomeDecorAPI.Application.Shared.ResponseFeatures;
using Microsoft.AspNetCore.Mvc;

namespace HomeDecorAPI.Presentation.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase {
        private readonly IServiceManager _service;
        private readonly IMapper _mapper;
        public AuthenticationController(IServiceManager service, IMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost("register")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistrationDto) {
            var result = await _service.AuthenticationService.RegisterUserAsync(userForRegistrationDto);

            if (!result.Succeeded) {
                var errors = result.Errors.Select(error => error.Description).ToList();
                return BadRequest(new ApiResponse<object>(
                    isSuccess: false,
                    message: "User registration failed.",
                    errors: errors
                ));
            }

            return StatusCode(201, new ApiResponse<object>(
                isSuccess: true,
                message: "User registered successfully."
            ));
        }

        [HttpPost("login")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> LoginUser([FromBody] UserForLoginDto userForLoginDto) {
            var user = await _service.AuthenticationService.LoginAsync(userForLoginDto);

            if (user == null) {

               
                return BadRequest(new ApiResponse<object>(
                    isSuccess: false,
                    message: "User login failed.",
                    errors: new List<string> { "Invalid login attempt." }
                ));
            }

            var tokenDto = await _service.AuthenticationService.CreateToken(true);
            if (tokenDto == null) {
                return StatusCode(500, new ApiResponse<object>(
                    isSuccess: false,
                    message: "Token generation failed.",
                    errors: new List<string> { "Unable to generate token." }
                ));
            }

       
            return Ok(new AuthResponse<UserDto>(
                isSuccess: true,
                message: "User login successful.",
                data: _mapper.Map<UserDto>(user),
                token: tokenDto.AccessToken,
                refreshToken: tokenDto.RefreshToken
            ));
        }

        [HttpPost("forgot-password")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> ChangePasswordAsync([FromBody] ChangePasswordDto changePasswordDto) {
            var result = await _service.AuthenticationService.ChangePasswordAsync(changePasswordDto);

            if (!result.Succeeded) {
                var errors = result.Errors.Select(error => error.Description).ToList();
                return BadRequest(new ApiResponse<object>(
                    isSuccess: false,
                    message: "User change password failed.",
                    errors: errors
                ));
            }

            return Ok(new ApiResponse<object>(
                isSuccess: true,
                message: "The user has successfully changed the password."
            ));
        }

        [HttpPost("logout")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Logout() {
            await _service.AuthenticationService.LogoutUserAsync();
            return Ok(new ApiResponse<object>(
                isSuccess: true,
                message: "User logged out successfully."
            ));
        }
    }
}
