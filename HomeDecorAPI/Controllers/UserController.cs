using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.DTOs.TokenDtos;
using HomeDecorAPI.Application.Shared.DTOs.UploadDtos;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos.HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;


namespace HomeDecorAPI.Presentation.Controllers {
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase {
        private readonly IServiceManager _service;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _enviroment;

        public UserController(IServiceManager service, IMapper mapper, IWebHostEnvironment environment) {
            _mapper = mapper;
            _service = service;
            _enviroment = environment;
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

        [HttpPost("{userId}/upload-avatar")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UploadAvarUserAsync(string userId, IFormFile file) {
            string uploadsFolder = Path.Combine(_enviroment.WebRootPath, "uploads");

            if (!Directory.Exists(uploadsFolder)) {
                Directory.CreateDirectory(uploadsFolder);
            }

            string uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create)) {
                await file.CopyToAsync(fileStream);
            }

            var result = await _service.UserService.UploadAvatarUserAsync(userId, uniqueFileName);

            if (!result.Succeeded) {
                var errors = result.Errors.Select(e => e.Description).ToList();
                return StatusCode(400, new ApiResponse<object>(
                    isSuccess: false,
                    message: "Failed to update avatar user profile.",
                    errors: errors
                ));
            }

            return Ok(new ApiResponse<object>(
                isSuccess: true,
                message: "User avatar profile updated successfully."
            ));
        }

        [HttpPut("upload-avatar")]
        [Authorize]
        public async Task<IActionResult> UploadAvatar([FromForm] UploadAvatarDto uploadAvatarDto) {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (userId == null) {
                return Unauthorized(new ApiResponse<object>(
                        isSuccess : false,
                        message: "User not authenticated."
                    ));
            }

            var fileUploadResult = await _service.FileUploadService.UploadAvatarFileAsync(uploadAvatarDto.File);

            if(fileUploadResult == null) {
                return BadRequest(new ApiResponse<object>(
                    isSuccess: false,
                    message: "File upload failed."
                    ));
            }

            var uploadAvatarResult = await _service.UserService.UploadAvatarUserAsync(userId, fileUploadResult);

            if (!uploadAvatarResult.Succeeded) {
                var errors = uploadAvatarResult.Errors.Select(e => e.Description).ToList();

                return BadRequest(new ApiResponse<object>(
                    isSuccess: false,
                    message: "Failed to upload user avatar",
                    errors: errors
                    ));
            }

            return Ok(new ApiResponse<string>(
                isSuccess: true,
                message: "Avatar uploaded successfully.",
                data: fileUploadResult
                ));
        } 
    }
}
