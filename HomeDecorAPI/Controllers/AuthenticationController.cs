using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using HomeDecorAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HomeDecorAPI.Presentation.Controllers {
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
                var errorResponse = new ApiResponse<object> {
                    IsSuccess = false,
                    Message = "User registration failed.",
                    Data = null,
                    Errors = errors,
                    
                };

                return BadRequest(errorResponse);
            }

            var response = new ApiResponse<object> {
                IsSuccess = true,
                Message = "User registered successfully.",
                Data = null,
                Errors = null
            };

            return StatusCode(201, response);
        }


        [HttpPost("login")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> LoginUser([FromBody] UserForLoginDto userForLoginDto) {
            var user = await _service.AuthenticationService.LoginAsync(userForLoginDto);

            if (user == null) {

                var errorResponse = new ApiResponse<object>(
                    isSuccess: false,
                    message: "User login failed.",
                    data: null,
                    errors: new List<string> { "Invalid login attempt." }
                );

                return BadRequest(errorResponse);
            }

            var tokenDto = await _service.AuthenticationService.CreateToken(true);
            if (tokenDto == null) {
                var errorResponse = new ApiResponse<object> {
                    IsSuccess = false,
                    Message = "Token generation failed.",
                    Data = null,
                    Errors = new List<string> { "Unable to generate token." }
                };

                return StatusCode(500, errorResponse);
            }

            var response = new AuthResponse<UserDto>(
                isSuccess: true,
                message: "User login successful.",
                data: _mapper.Map<UserDto>(user),
                token: tokenDto.AccessToken,
                refreshToken: tokenDto.RefreshToken,
                errors: null
            );

            return Ok(response);
        }

    }

}
