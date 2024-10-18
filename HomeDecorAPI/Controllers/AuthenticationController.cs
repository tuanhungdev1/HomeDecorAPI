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
using System.Linq.Expressions;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using HomeDecorAPI.Domain.Exceptions.BadRequestException;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.UnauthorizedException;

namespace HomeDecorAPI.Presentation.Controllers {
    [Route("api/auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase {
        private readonly IAuthenticationService _authenticationService;
        private readonly IMapper _mapper;
        private readonly ILogger<AuthenticationController> _logger; 

        public AuthenticationController(IAuthenticationService authenticationService, IMapper mapper, ILogger<AuthenticationController> logger) {
            _authenticationService = authenticationService;
            _mapper = mapper;
            _logger = logger; 
        }

        [HttpPost("register")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistrationDto) {
            _logger.LogInformation("Bắt đầu sử lý đăng kí người dùng mới trong hệ thống.");
            try {
                var result = await _authenticationService.RegisterUserAsync(userForRegistrationDto);

                _logger.LogInformation($"Người dùng đăng kí thành công với Username: {userForRegistrationDto.Username}");
                return StatusCode(201, new ApiResponse<object> {
                    Success = true,
                    Message = "Chúc mừng bạn đã đăng kí tài khoản thành công!",
                    StatusCode = 201
                });
            }catch(RegisterUserException ex) {
                _logger.LogError(ex, "Thông tin đăng kí người dùng không chính xác.");
                return BadRequest(new ApiResponse<object> {
                    Success = false,
                    Message = "Thông tin đăng kí không chính xác!, Vui lòng kiểm tra lại.",
                    StatusCode = 400
                });
            } catch (Exception ex) {
                _logger.LogError(ex, "An error occurred while registering user."); 
                return StatusCode(500, new ApiResponse<object> {
                    Success = false,
                    Message = "An internal server error occurred. Please try again later.",
                    StatusCode = 500
                });
            }
        }

        [HttpPost("admin/login")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> LoginAdmin([FromBody] UserForLoginDto userForLoginDto) {
            _logger.LogInformation("Bắt đầu sử lý thông tin đăng nhập Admin");

            try {
                var adminDto = await _authenticationService.LogoutAdminAsync(userForLoginDto);

                _logger.LogInformation("User đăng nhập thành công bắt đầu tạo AccessToken và RefreshToken");
                var tokenDto = await _authenticationService.CreateToken(true);

                _logger.LogInformation("Tạo token thành công và gửi thông tin đăng nhập về client.");
                return Ok(new AuthResponse<UserDto> {
                    Success = true,
                    Message = "Admin đăng nhập thành công.",
                    Data = adminDto,
                    Token = tokenDto.AccessToken,
                    RefreshToken = tokenDto.RefreshToken,
                    StatusCode = 200
                });
            } catch (UserNotFoundException ex) {
                _logger.LogError(ex, "Không tìm thấy người dùng trong hệ thống.");
                return BadRequest(new ApiResponse<object> {
                    Success = false,
                    Message = "Thông tin đăng nhập không chính xác! Sai tên đăng nhập.",
                    StatusCode = 400
                });
            } catch (LoginBadRequest ex) {
                _logger.LogError(ex, "Thông tin đăng nhập không chính xác! Sai mật khẩu.");
                return BadRequest(new ApiResponse<object> {
                    Success = false,
                    Message = "Thông tin đăng nhập không chính xác! Sai mật khẩu.",
                    StatusCode = 400
                });
            }catch(AccessDeniedException ex) {
                _logger.LogError(ex, "Người dùng không có quyền truy cập.");
                return StatusCode(StatusCodes.Status403Forbidden , new ApiResponse<object> {
                    Success = false,
                    Message = "Thông tin đăng nhập không chính xác! Sai mật khẩu.",
                    StatusCode = 403
                });
            } catch (Exception ex) {
                _logger.LogError(ex, "Có một vài vấn đề nào đó của hệ thông gặp lỗi.");
                return StatusCode(500, new ApiResponse<object> {
                    Success = false,
                    Message = "Hệ thống của bạn gặp một vài vấn đề, hãy thử lại.",
                    StatusCode = 500
                });
            }
        }

        [HttpPost("login")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> LoginUser([FromBody] UserForLoginDto userForLoginDto) {
            _logger.LogInformation("Sử lý thông tin đăng nhập của người dùng");
            try {
                var user = await _authenticationService.LoginAsync(userForLoginDto);

                _logger.LogInformation("User đăng nhập thành công bắt đầu tạo AccessToken và RefreshToken");
                var tokenDto = await _authenticationService.CreateToken(true);

                _logger.LogInformation("Tạo token thành công và gửi thông tin đăng nhập về client."); 
                return Ok(new AuthResponse<UserDto> {
                    Success = true,
                    Message = "User login successful.",
                    Data = user,
                    Token = tokenDto.AccessToken,
                    RefreshToken = tokenDto.RefreshToken,
                    StatusCode = 200
                });
               

            } catch(LoginException ex) {
                _logger.LogWarning(ex, $"Thông tin đăng nhập của người dùng không chính xác! Sai username hoặc password.");
                return BadRequest(new ApiResponse<object> {
                    Success = false,
                    Message = "Thông tin đăng nhập không chính xác! Sai Username hoặc Password.",
                    StatusCode = 400
                });

            } catch (Exception ex) {
                _logger.LogError(ex, "An error occurred while logging in user."); 
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
                    _logger.LogWarning("User change password failed: {Errors}", string.Join(", ", errors)); 
                    return BadRequest(new ApiResponse<object> {
                        Success = false,
                        Message = "User change password failed.",
                        Errors = errors,
                        StatusCode = 400
                    });
                }

                _logger.LogInformation("User changed password successfully: {Username}", changePasswordDto.Username); 
                return Ok(new ApiResponse<object> {
                    Success = true,
                    Message = "The user has successfully changed the password.",
                    StatusCode = 200
                });
            } catch (Exception ex) {
                _logger.LogError(ex, "An error occurred while changing password."); 
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
