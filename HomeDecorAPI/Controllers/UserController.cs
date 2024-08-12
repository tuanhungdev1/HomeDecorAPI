using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.DTOs.TokenDtos;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos.HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using Microsoft.AspNetCore.Mvc;

namespace HomeDecorAPI.Presentation.Controllers {
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase {
        private readonly IServiceManager _service;
        private readonly IMapper _mapper;

        public UserController(IServiceManager service, IMapper mapper) {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet("{userId}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetUserProfileAsync(string userId) {
            var user = await _service.UserService.GetUserProfileAsync(userId);

            if (user == null) {
                return StatusCode(500, new ApiResponse<object>(
                    isSuccess: false,
                    message: "Failed to retrieve user profile.",
                    errors: new List<string> { "The user profile could not be found or retrieved." }
                ));
            }

            return Ok(new ApiResponse<object>(
                isSuccess: true,
                message: "User profile retrieved successfully.",
                data: _mapper.Map<UserProfileDto>(user),
                errors: null
            ));
        }

        [HttpPost("{userId}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateUserProfileAsync(string userId, [FromBody] UserForUpdateProfileDto userForUpdateProfile) {
            var result = await _service.UserService.UpdateUserProfileAsync(userId, userForUpdateProfile);

            if (!result.Succeeded) {
                var errors = result.Errors.Select(e => e.Description).ToList();
                return StatusCode(400, new ApiResponse<object>(
                    isSuccess : false,
                    message: "Failed to update user profile.",
                    errors: errors
                ));
            }

            return Ok(new ApiResponse<object>(
                isSuccess: true,
                message: "User profile updated successfully."
            ));
        }


        [HttpPost("{userId}/addresses")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetAllUserAddressAsync(string userId) {
            var addressListForUser = await _service.UserService.GetAllUserAddressAsync(userId);

            if (addressListForUser == null || !addressListForUser.Any()) {
                return StatusCode(404, new ApiResponse<object>(
                    isSuccess: false,
                    message: "No addresses found for the specified user."
                ));
            }

            return Ok(new ApiResponse<object>(
                isSuccess: true,
                message: "Addresses retrieved successfully.",
                data: addressListForUser
            ));
        }

    }
}
