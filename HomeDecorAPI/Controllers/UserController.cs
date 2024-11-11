﻿using AutoMapper;
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
        
    }
}
