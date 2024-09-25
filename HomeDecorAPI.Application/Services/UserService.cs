using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.AddressDtos;
using HomeDecorAPI.Application.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos.HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Services {
    public class UserService : IUserService {
        private readonly UserManager<User> _userService;
        private readonly IMapper _mapper;

        public UserService(UserManager<User> userManager, IMapper mapper) {
            _userService = userManager;
            _mapper = mapper;
        }

        // Lấy thông tin profile người dùng
        public async Task<UserProfileDto> GetUserProfileAsync(string userId) {
            var user = await _userService.FindByIdAsync(userId);

            if (user == null) {
                throw new UserNotFoundException($"UserId {userId} not found in the system.");
            }

            return _mapper.Map<UserProfileDto>(user);
        }

        // Cập nhật thông tin người dùng
        public async Task<UserDto> UpdateUserProfileAsync(string userId, UserForUpdateProfileDto userForUpdateProfileDto) {
            var user = await _userService.FindByIdAsync(userId);
            if (user == null) {
                throw new UserNotFoundException($"UserId {userId} not found in the system.");
            }

            
            _mapper.Map(userForUpdateProfileDto, user);
            var result = await _userService.UpdateAsync(user);

            if (!result.Succeeded) {
                throw new Exception("Error occurred while updating user profile.");
            }

            
            var updatedUser = await _userService.FindByIdAsync(userId);

            
            return _mapper.Map<UserDto>(updatedUser);
        }

        // Lấy tất cả địa chỉ của người dùng
        public async Task<IEnumerable<AddressDto>> GetAllUserAddressAsync(string userId) {
            var user = await _userService.FindByIdAsync(userId);

            if (user == null) {
                throw new UserNotFoundException($"UserId {userId} not found in the system.");
            }

            var addressList = user.Addresses;

            return _mapper.Map<IEnumerable<AddressDto>>(addressList);
        }

        // Tải lên ảnh đại diện cho người dùng
        public async Task<IdentityResult> UploadAvatarUserAsync(string userId, string avatarUrl) {
            var user = await _userService.FindByIdAsync(userId);

            if (user == null) {
                throw new UserNotFoundException($"UserId {userId} not found in the system.");
            }

            user.ProfilePicture = avatarUrl;

            var result = await _userService.UpdateAsync(user);

            return result;
        }
    }
}
