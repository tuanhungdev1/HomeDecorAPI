using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.AddressDtos;
using HomeDecorAPI.Application.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos.HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Services {
    public class UserService : IUserService {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly ILogger<UserService> _logger;

        public UserService(UserManager<User> userManager, IMapper mapper, ILogger<UserService> logger) {
            _userManager = userManager;
            _mapper = mapper;
            _logger = logger;
        }

        // Lấy thông tin profile người dùng
        public async Task<UserProfileDto> GetUserProfileAsync(string userId) {
            _logger.LogInformation("Attempting to retrieve user profile for userId: {userId}", userId);
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null) {
                _logger.LogWarning("User not found with userId: {userId}", userId);
                throw new UserNotFoundException($"UserId {userId} not found in the system.");
            }
            _logger.LogInformation("Successfully retrieved user profile for userId: {userId}", userId);
            return _mapper.Map<UserProfileDto>(user);
        }

        // Cập nhật thông tin người dùng
        public async Task UpdateUserProfileAsync(string userId, UserForUpdateProfileDto userForUpdateProfileDto) {
            _logger.LogInformation("Attempting to update user profile for userId: {userId}", userId);
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) {
                _logger.LogWarning("User not found with userId: {userId}", userId);
                throw new UserNotFoundException(userId);
            }
            
            _mapper.Map(userForUpdateProfileDto, user);
            var result = await _userManager.UpdateAsync(user);

            if (!result.Succeeded) {
                _logger.LogError("Error occurred while updating user profile for userId: {userId}", userId);
                throw new Exception("Error occurred while updating user profile.");
            }

            _logger.LogInformation("Successfully updated user profile for userId: {userId}", userId);
        }

        // Lấy tất cả địa chỉ của người dùng
        public async Task<IEnumerable<AddressDto>> GetAllUserAddressAsync(string userId) {
            _logger.LogInformation("Attempting to update user profile for userId: {userId}", userId);
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) {
                _logger.LogWarning("User not found with userId: {userId}", userId);
                throw new UserNotFoundException(userId);
            }

            var addressList = user.Addresses;
            _logger.LogInformation("Successfully retrieved user address for userId: {userId}", userId);
            return _mapper.Map<IEnumerable<AddressDto>>(addressList);
        }
    }
}
