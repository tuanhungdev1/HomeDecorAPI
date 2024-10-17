using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.UserDtos;
using HomeDecorAPI.Application.DTOs.TokenDtos;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging; // Thêm logging
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDecorAPI.Presentation.Controllers {
    [Route("api/auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase {
        private readonly IAuthenticationService _authenticationService;
        private readonly IMapper _mapper;
        private readonly ILogger<AuthenticationController> _logger; // Khai báo logger

        public AuthenticationController(IAuthenticationService authenticationService, IMapper mapper, ILogger<AuthenticationController> logger) {
            _authenticationService = authenticationService;
            _mapper = mapper;
            _logger = logger; // Khởi tạo logger
        }

        [HttpPost("register")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistrationDto) {
            try {
                var result = await _authenticationService.RegisterUserAsync(userForRegistrationDto);
                if (!result.Succeeded) {
                    var errors = result.Errors.Select(error => error.Description).ToList();
                    _logger.LogWarning("User registration failed: {Errors}", string.Join(", ", errors)); // Logging cảnh báo
                    return BadRequest(new ApiResponse<object> {
                        Success = false,
                        Message = "User registration failed.",
                        Errors = errors,
                        StatusCode = 400 // Mã trạng thái lỗi
                    });
                }

                _logger.LogInformation($"User registered successfully: {userForRegistrationDto.UserName}"); // Logging thông tin
                return StatusCode(201, new ApiResponse<object> {
                    Success = true,
                    Message = "User registered successfully.",
                    StatusCode = 201
                });
            } catch (Exception ex) {
                _logger.LogError(ex, "An error occurred while registering user."); // Logging lỗi
                return StatusCode(500, new ApiResponse<object> {
                    Success = false,
                    Message = "An internal server error occurred. Please try again later.",
                    StatusCode = 500
                });
            }
        }

        [HttpPost("login")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> LoginUser([FromBody] UserForLoginDto userForLoginDto) {
            try {
                var user = await _authenticationService.LoginAsync(userForLoginDto);
                if (user == null) {
                    _logger.LogWarning($"Invalid login attempt for username: {userForLoginDto.UserName}"); // Logging cảnh báo
                    return BadRequest(new ApiResponse<object> {
                        Success = false,
                        Message = "Invalid username or password.",
                        StatusCode = 400
                    });
                }

                var tokenDto = await _authenticationService.CreateToken(true);
                if (tokenDto == null) {
                    _logger.LogError($"Token generation failed for user: {userForLoginDto.UserName}"); // Logging lỗi
                    return StatusCode(500, new ApiResponse<object> {
                        Success = false,
                        Message = "Token generation failed.",
                        Errors = new List<string> { "Unable to generate token." },
                        StatusCode = 500
                    });
                }

                _logger.LogInformation("User login successful: {Username}", userForLoginDto.UserName); // Logging thông tin
                return Ok(new AuthResponse<string> {
                    Success = true,
                    Message = "User login successful.",
                    Data = user.Id,
                    Token = tokenDto.AccessToken,
                    RefreshToken = tokenDto.RefreshToken,
                    StatusCode = 200
                });
            } catch (Exception ex) {
                _logger.LogError(ex, "An error occurred while logging in user."); // Logging lỗi
                return StatusCode(500, new ApiResponse<object> {
                    Success = false,
                    Message = "An internal server error occurred. Please try again later.",
                    StatusCode = 500
                });
            }
        }

        [HttpPost("forgot-password")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> ChangePasswordAsync([FromBody] ChangePasswordDto changePasswordDto) {
            try {
                var result = await _authenticationService.ChangePasswordAsync(changePasswordDto);
                if (!result.Succeeded) {
                    var errors = result.Errors.Select(error => error.Description).ToList();
                    _logger.LogWarning("User change password failed: {Errors}", string.Join(", ", errors)); // Logging cảnh báo
                    return BadRequest(new ApiResponse<object> {
                        Success = false,
                        Message = "User change password failed.",
                        Errors = errors,
                        StatusCode = 400
                    });
                }

                _logger.LogInformation("User changed password successfully: {Username}", changePasswordDto.Username); // Logging thông tin
                return Ok(new ApiResponse<object> {
                    Success = true,
                    Message = "The user has successfully changed the password.",
                    StatusCode = 200
                });
            } catch (Exception ex) {
                _logger.LogError(ex, "An error occurred while changing password."); // Logging lỗi
                return StatusCode(500, new ApiResponse<object> {
                    Success = false,
                    Message = "An internal server error occurred. Please try again later.",
                    StatusCode = 500
                });
            }
        }

        [Authorize]
        [HttpPost("logout")]
        public async Task<IActionResult> Logout () {
            try {
                await _authenticationService.LogoutUserAsync();
                _logger.LogInformation("User logged out successfully.");
                return Ok(new ApiResponse<object> {
                    Success = true,
                    Message = "User logged out successfully.",
                    StatusCode = 200
                });
            } catch (UnauthorizedAccessException ex) {
                _logger.LogWarning(ex, "Unauthorized access attempt during logout.");
                return Unauthorized(new ApiResponse<object> {
                    Success = false,
                    Message = "Unauthorized access. User may not be logged in.",
                    StatusCode = 401
                });
            } catch (InvalidOperationException ex) {
                _logger.LogError(ex, "Invalid operation occurred during logout.");
                return BadRequest(new ApiResponse<object> {
                    Success = false,
                    Message = "Unable to complete logout process. Please try again.",
                    StatusCode = 400
                });
            } catch (Exception ex) {
                _logger.LogError(ex, "An unexpected error occurred while logging out user.");
                return StatusCode(500, new ApiResponse<object> {
                    Success = false,
                    Message = "An internal server error occurred. Please try again later.",
                    StatusCode = 500
                });
            }
        }
    }
}
