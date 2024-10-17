using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using HomeDecorAPI.Application.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeDecorAPI.Application.Shared.Utilities;
using HomeDecorAPI.Application.Shared.Constants;
using HomeDecorAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Shared.Models;

namespace HomeDecorAPI.Application.Services {
    public class CloudinaryService : ICloudinaryService {
        private readonly Cloudinary _cloudinary;
        private readonly CloudinarySettings _cloudinarySettings;
        private readonly ILogger<CloudinaryService> _logger;
        private readonly UserManager<User> _userManager;
        private readonly IUnitOfWork _unitOfWork;

        public CloudinaryService(IOptions<CloudinarySettings> cloudinarySettings, ILogger<CloudinaryService> logger, UserManager<User> userManager, IUnitOfWork unitOfWork) {
            _cloudinarySettings = cloudinarySettings.Value;
            
            var acc = new Account(
                _cloudinarySettings.CloudName,
                _cloudinarySettings.ApiKey,
                _cloudinarySettings.ApiSecret);

            _cloudinary = new Cloudinary(acc);
            _logger = logger;
            _userManager = userManager;
            _unitOfWork = unitOfWork;
        }

        public async Task<UploadResult> UploadUserAvatarAsync(IFormFile file, string userId) {
            _logger.LogInformation("Started uploading avatar for userId: {UserId}", userId);
            try {
                _unitOfWork.CreateTransaction();
                FileHelper.ValidateFile(file);
                _logger.LogInformation("Validated file for userId: {UserId}. FileName: {FileName}, FileSize: {FileSize} bytes", userId, file.FileName, file.Length);

                var user = await _unitOfWork.UserRepository.GetUserImageAsync(userId);
                if (user == null) {
                    _logger.LogWarning("User not found while uploading avatar. UserId: {UserId}", userId);
                    throw new UserNotFoundException(userId);
                }

                var uniqueFileName = FileHelper.GenerateUniqueFileName(file.FileName, CloudinaryConstants.FileTypes.UserAvatar);
                _logger.LogInformation("Generated unique file name for userId: {UserId}. FileName: {UniqueFileName}", userId, uniqueFileName);

                using var stream = file.OpenReadStream();
                var uploadParams = new ImageUploadParams {
                    File = new FileDescription(file.FileName, stream),
                    Folder = $"HomeDecor/{CloudinaryConstants.Folders.Users}/{uniqueFileName}",
                    PublicId = user.UserImage?.PublicId ?? uniqueFileName,
                    Overwrite = true,
                    Transformation = new Transformation()
                        .Width(1000)
                        .Height(1000)
                        .Crop("limit")
                        .Quality(85)
                };

                var uploadResult = await _cloudinary.UploadAsync(uploadParams);

                if (uploadResult.Error != null) {
                    _logger.LogError("Error occurred while uploading to Cloudinary. Error: {ErrorMessage}", uploadResult.Error.Message);
                    throw new Exception(uploadResult.Error.Message);
                }

                _logger.LogInformation("Successfully uploaded avatar for userId: {UserId}. Cloudinary URL: {Url}", userId, uploadResult.SecureUrl);
                
                if(user.UserImage == null) {
                    var userImage = new UserImage {
                        PublicId = uploadResult.PublicId.ToString(),
                        UserId = userId,
                        Url = uploadResult.SecureUrl.ToString(),
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                    };

                    user.UserImage = userImage;
                }else {
                    user.UserImage.UpdateTimestamp();
                }
                   
                _logger.LogInformation("User's avatar URL updated in database for userId: {UserId}", userId);
                await _unitOfWork.SaveChangesAsync();
                _unitOfWork.Commit();
                return uploadResult;
            } catch (Exception ex) {
                _unitOfWork.Rollback();
                _logger.LogError(ex, "Error uploading avatar for userId: {UserId}", userId);
                throw new Exception("Failed to upload user avatar", ex);
            }
        }

        public async Task<DeletionResult> DeleteUserAvatarAsync(string userId) {
            _logger.LogInformation("Started deleting avatar for userId: {userId}", userId);
            try {
                _unitOfWork.CreateTransaction();
                var user = await _unitOfWork.UserRepository.GetUserImageAsync(userId);
                if (user == null) {
                    _logger.LogWarning("User not found while attempting to delete avatar. UserId: {UserId}", userId);
                    throw new UserNotFoundException(userId);
                }

                if(user.UserImage == null) {
                    _logger.LogWarning("User does not have an avatar. UserId: {UserId}", userId);
                    throw new UserImageNotFoundException(userId);
                }

                var deleteParams = new DeletionParams(user.UserImage.PublicId);
                var result = await _cloudinary.DestroyAsync(deleteParams);

                if (result.Error != null) {
                    _logger.LogError("Error occurred while deleting file from Cloudinary. Error: {ErrorMessage}", result.Error.Message);
                    throw new Exception(result.Error.Message);
                }

                _logger.LogInformation("Successfully deleted avatar from Cloudinary for userId: {UserId}, PublicId: {PublicId}", userId, user.UserImage.PublicId);
                user.UserImage = null;
                await _unitOfWork.SaveChangesAsync();
                _unitOfWork.Commit();
                return result;
            } catch (Exception ex) {
                _unitOfWork.Rollback();
                _logger.LogError(ex, "Error deleting avatar for userId: {userId}", userId);
                throw new Exception("Failed to delete user avatar", ex);
            }
        }
    }
}
