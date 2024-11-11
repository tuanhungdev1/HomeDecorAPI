using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.AddressDtos;
using HomeDecorAPI.Application.DTOs.BrandDtos;
using HomeDecorAPI.Application.DTOs.UserDtos;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Shared.Constants;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos.HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Services {
    public class UserService : IUserService {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly ILoggerService _logger;
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICloudinaryService _cloudinaryService;

        public UserService(UserManager<User> userManager,
                            IMapper mapper,
                            ILoggerService logger,
                            IUserRepository userRepository,
                            IUnitOfWork unitOfWork,
                            ICloudinaryService cloudinaryService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _logger = logger;
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _cloudinaryService = cloudinaryService;
        }

        public async Task<UserDto> GetUserInfoAsync(string userId) {
          
            var user = await _userRepository
                            .FindByCondition(u => u.Id == userId, false)
                            .FirstOrDefaultAsync();
            if (user == null) {
                _logger.LogError($"User not found with userId: {userId}");
                throw new UserNotFoundException($"{userId}");
            }
            var roles = await _userManager.GetRolesAsync(user);
            var userDto = _mapper.Map<UserDto>(user);
            userDto.Roles = roles;
            return userDto;
        }
        public async Task<UserDto> UpdateUserInforAsync(string userId, UserForUpdateDto userForUpdateDto) {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                _logger.LogError($"User not found with userId: {userId}");
                throw new UserNotFoundException(userId);
            }
            try
            {
                await _unitOfWork.BeginTransactionAsync();   
                _mapper.Map(userForUpdateDto, user);
                await _unitOfWork.SaveChangesAsync();

                await UpdateUserRoles(user, userForUpdateDto.Roles);

                if(userForUpdateDto.FileImage != null)
                {
                    string folder = $"HomeDecor/{CloudinaryConstants.Folders.Users}/ID_{user.Id}/";
                    string oldPublicId = _cloudinaryService.GetPublicIdFromUrl(user.ImageUrl);
                    user.ImageUrl = await _cloudinaryService.ReplaceImageAsync(userForUpdateDto.FileImage, oldPublicId, folder, CloudinaryConstants.FileTypes.BrandImage);
                    _logger.LogInfo($"Cập nhật hình ảnh mới cho User thành công với URL: {user.ImageUrl}");
                } else if(user.ImageUrl != null && userForUpdateDto.isDeleteImage)
                {
                    var publicId = _cloudinaryService.GetPublicIdFromUrl(user.ImageUrl);
                    await _cloudinaryService.DeleteImageAsync(publicId);
                    user.ImageUrl = null;
                    _logger.LogInfo($"Xóa thành công Image User với PublicId: {publicId}");
                }

                _userRepository.Update(user);
                await _unitOfWork.SaveChangesAsync();
                var userDto = _mapper.Map<UserDto>(user);
                var userRoles = await _userManager.GetRolesAsync(user);
                userDto.Roles = userRoles;
                await _unitOfWork.CommitAsync();
                return userDto;
            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                _logger.LogError($"Có lỗi sảy ra khi Update User với ID: {userId}");
                throw ex;
            }
        }

        private async Task UpdateUserRoles(User user, IEnumerable<string> newRoles)
        {
            var currentRoles = await _userManager.GetRolesAsync(user);
            var rolesAreDifferent = !currentRoles.OrderBy(r => r).SequenceEqual(newRoles.OrderBy(nr => nr));
            if (rolesAreDifferent)
            {
                var removeRolesResult = await _userManager.RemoveFromRolesAsync(user, currentRoles);

                if (!removeRolesResult.Succeeded)
                {
                    throw new Exception("Có lỗi phát sinh không thể xóa Roles hiện tại của người dùng.");
                }

                var addRolesResult = await _userManager.AddToRolesAsync(user, newRoles);

                if(!addRolesResult.Succeeded)
                {
                    throw new Exception("Có lỗi phát sinh không thể cập nhật Roles mới cho người dùng.");
                }
            }
        }
    }
}
