using AutoMapper;
using CloudinaryDotNet.Actions;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.AddressDtos;
using HomeDecorAPI.Application.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos.HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HomeDecorAPI.Presentation.Controllers {
    [Authorize]
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _environment;
        private readonly ILogger<UserController> _logger;
        private readonly ICloudinaryService _cloudinaryService;

        public UserController(IUserService userService, IMapper mapper, IWebHostEnvironment environment, ILogger<UserController> logger, ICloudinaryService cloudinaryService) {
            _mapper = mapper;
            _environment = environment;
            _userService = userService;
            _logger = logger;
            _cloudinaryService = cloudinaryService;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserProfileAsync(string userId) {
            try {
                var user = await _userService.GetUserProfileAsync(userId);
                _logger.LogInformation("User profile retrieved successfully for userId: {userId}", userId);
                return Ok(new ApiResponse<UserDto> {
                    Success = true,
                    Message = "User profile retrieved successfully.",
                    Data = user,
                    StatusCode = StatusCodes.Status200OK,
                });
                } catch (UserNotFoundException ex) {
                _logger.LogWarning(ex, $"User not found for userId: {userId}");
                return BadRequest(new ApiResponse<UserProfileDto> {
                    Success = false,
                    Message = "Failed to retrieve user profile.",
                    StatusCode = StatusCodes.Status400BadRequest,
                    Errors = new List<string> { "The user profile could not be found or retrieved." },
                });


            } catch (Exception ex) {
                _logger.LogInformation(ex, $"Error occurred while retrieving user profile for userId:{userId}");
                return BadRequest(new ApiResponse<UserProfileDto> {
                    Success = false,
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = "An error occurred while retrieving the user profile.",
                    Errors = new List<string> { "Unexpected error. Please try again later." }
                });
            }
        }

        [HttpPut("{userId}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateUserProfileAsync(string userId, [FromBody] UserForUpdateProfileDto userForUpdateProfile) {
            _logger.LogInformation("Received request to update profile for userId: {userId}", userId);

            try {
                var user = await _userService.GetUserProfileAsync(userId);

                if (user == null) {
                    _logger.LogWarning("User not found for userId: {userId}", userId);
                    return BadRequest(new ApiResponse<UserProfileDto> {
                        Success = false,
                        Message = "Failed to retrieve user profile.",
                        StatusCode = StatusCodes.Status400BadRequest,
                        Errors = new List<string> { "The user profile could not be found or retrieved." },
                    });
                }
                await _userService.UpdateUserProfileAsync(userId, userForUpdateProfile);

                _logger.LogInformation("User profile updated successfully for userId: {userId}", userId);

                return Ok(new ApiResponse<UserDto> {
                    Success = true,
                    Message = "User profile updated successfully.",
                    StatusCode = StatusCodes.Status200OK,
                });
            } catch (Exception ex) {
                _logger.LogInformation(ex, "Error occurred while retrieving user profile for userId:{userId}", userId);
                return BadRequest(new ApiResponse<UserProfileDto> {
                    Success = false,
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = "An error occurred while retrieving the user profile.",
                    Errors = new List<string> { "Unexpected error. Please try again later." }
                });
            }
        }

        [HttpPost("{userId}/addresses")]
        public async Task<IActionResult> GetAllUserAddressAsync(string userId) {
            _logger.LogInformation("Received request to get all addresses for userId: {userId}", userId);
            try {
                var addressListForUser = await _userService.GetAllUserAddressAsync(userId);

                if (addressListForUser == null || !addressListForUser.Any()) {
                    _logger.LogWarning("No addresses found for userId: {userId}", userId);
                    return NotFound(new ApiResponse<object> {
                        Success = false,
                        Message = "No addresses found for the specified user.",
                        StatusCode = StatusCodes.Status404NotFound
                    });
                }

                _logger.LogInformation("Addresses retrieved successfully for userId: {userId}", userId);

                return Ok(new ApiResponse<IEnumerable<AddressDto>> {
                    Success = true,
                    Message = "Addresses retrieved successfully.",
                    Data = addressListForUser,
                    StatusCode = StatusCodes.Status200OK
                });
            } catch (Exception ex) {
                _logger.LogError(ex, "Error occurred while retrieving addresses for userId: {userId}", userId);
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<object> {
                    Success = false,
                    Message = "An error occurred while retrieving the addresses.",
                    Errors = new List<string> { "Unexpected error. Please try again later." },
                    StatusCode = StatusCodes.Status500InternalServerError
                });
            }
        }

        [HttpPost("{userId}/upload-avatar")]
        public async Task<IActionResult> UploadAvatarUserAsync(string userId, IFormFile file) {
            _logger.LogInformation("Received request to upload avatar for userId: {userId}", userId);
            try {
                var uploadResult = await _cloudinaryService.UploadUserAvatarAsync(file, userId);

                return Ok(new ApiResponse<UploadResult> {
                    Success = true,
                    Message = "Avatar uploaded successfully.",
                    Data = uploadResult,
                    StatusCode = StatusCodes.Status200OK,
                });
            } catch (UserNotFoundException ex) {
                _logger.LogWarning(ex, "User not found for userId: {userId}", userId);
                return NotFound(new ApiResponse<object> {
                    Success = false,
                    Message = "User not found.",
                    StatusCode = StatusCodes.Status404NotFound
                });
            } catch (Exception ex) {
                _logger.LogError(ex, "Error occurred while uploading avatar for userId: {userId}", userId);
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<object> {
                    Success = false,
                    Message = "An error occurred while uploading the avatar.",
                    Errors = new List<string> { "Unexpected error. Please try again later." },
                    StatusCode = StatusCodes.Status500InternalServerError
                });
            }
        }

        [HttpDelete("{userId}/delete-avatar")]
        public async Task<IActionResult> DeleteUserAvatarAsync(string userId) {
            _logger.LogInformation("Received request to delete avatar for userId: {userId}", userId);
            try {
                var deletionResult = await _cloudinaryService.DeleteUserAvatarAsync(userId);

                return Ok(new ApiResponse<DeletionResult> {
                    Success = true,
                    Message = "Avatar deleted successfully.",
                    Data = deletionResult,
                    StatusCode = StatusCodes.Status200OK,
                });
            } catch (UserNotFoundException ex) {
                _logger.LogWarning(ex, "User not found for userId: {userId}", userId);
                return NotFound(new ApiResponse<object> {
                    Success = false,
                    Message = "User not found.",
                    StatusCode = StatusCodes.Status404NotFound
                });
            } catch (UserImageNotFoundException ex) {
                _logger.LogWarning(ex, "User image not found for userId: {userId}", userId);
                return NotFound(new ApiResponse<object> {
                    Success = false,
                    Message = "User does not have an avatar to delete.",
                    StatusCode = StatusCodes.Status404NotFound
                });
            } catch (Exception ex) {
                _logger.LogError(ex, "Error occurred while deleting avatar for userId: {userId}", userId);
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<object> {
                    Success = false,
                    Message = "An error occurred while deleting the avatar.",
                    Errors = new List<string> { "Unexpected error. Please try again later." },
                    StatusCode = StatusCodes.Status500InternalServerError
                });
            }
        }
    }
}
