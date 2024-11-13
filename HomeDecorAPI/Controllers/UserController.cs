using AutoMapper;
using CloudinaryDotNet.Actions;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.AddressDtos;
using HomeDecorAPI.Application.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos.HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using HomeDecorAPI.Application.Shared.Utilities;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HomeDecorAPI.Presentation.Controllers {
    //[Authorize]
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase {
        private readonly IUserService _userService;
        private readonly ILoggerService _logger;
        public UserController(IUserService userService, IMapper mapper,  ILoggerService logger) {
            _userService = userService;
            _logger = logger;
        
        }


        [HttpGet]
        public async Task<ActionResult> GetAllUserAsync([FromQuery] UserRequestParameters userRequestParameters)
        {
            var (userDtos, metaData) = await _userService.GetAllUserAsync(userRequestParameters);
            _logger.LogInfo("Lấy thành công danh sách User.");
            Response.AddPaginationHeader(metaData);
            return Ok(new ApiResponse<IEnumerable<UserDto>>
            {
                Success = true,
                StatusCode = 200,
                Data = userDtos,
                Message = "Lấy danh sách dữ liệu User thành công."
            });
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserAsync(string userId) {
                var user = await _userService.GetUserInfoAsync(userId);
                _logger.LogInfo($"User profile retrieved successfully for userId: {userId}");
                return Ok(new ApiResponse<UserDto>
                {
                    Success = true,
                    Message = "User profile retrieved successfully.",
                    Data = user,
                    StatusCode = StatusCodes.Status200OK,
                });
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateUserAsync([FromBody] UserForCreateDto userForCreateDto)
        {
            var userDto = await _userService.CreateUserAsync(userForCreateDto);
            _logger.LogInfo("Tạo thành công một người dùng mới.");
            return Ok(new ApiResponse<UserDto>
            {
                Success = true,
                StatusCode = 201,
                Data = userDto,
                Message = "Tạo mới một người dùng thành công."
            });
        }

		[HttpPut("{userId}/roles")]
		[Authorize(Roles = "Admin")]
		[ServiceFilter(typeof(ValidationFilterAttribute))]
		public async Task<IActionResult> UpdateUserRolesAsync(string userId, [FromBody] UserUpdateRolesDto userUpdateRolesDto)
		{
			var userDto = await _userService.UpdateUserRolesAsync(userId, userForUpdateDto);
			_logger.LogInfo($"Cập nhật Roles User thành công với UserId: {userId}");
			return Ok(new ApiResponse<UserDto>
			{
				Success = true,
				Message = $"Cập nhật Roles User thành công với UserId: {userId}",
				Data = userDto,
				StatusCode = StatusCodes.Status200OK,
			});
		}

		[HttpPut("{userId}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateUserAsync(string userId, [FromBody] UserForUpdateDto userForUpdateProfile) {
               var userDto = await _userService.UpdateUserInforAsync(userId, userForUpdateProfile);
                _logger.LogInfo($"Cập nhật thông tin User thành công với UserId: {userId}");
                return Ok(new ApiResponse<UserDto> {
                    Success = true,
                    Message = $"Cập nhật thông tin User thành công với UserId: {userId}",
                    Data = userDto,
                    StatusCode = StatusCodes.Status200OK,
                });
        }

        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteUserAsync(string userId)
        {
            await _userService.DeleteUserAsync(userId);
            _logger.LogInfo($"Xóa thành công User với ID:{userId}");
            return Ok(new ApiResponse<string>
            {
                Success= true,
                StatusCode = StatusCodes.Status200OK,
                Message = $"Xóa thành công User với ID:{userId}",
            });
        }
        
    }
}
