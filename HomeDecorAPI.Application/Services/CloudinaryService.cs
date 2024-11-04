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

        public async Task<string> UploadImageAsync(IFormFile file, string folder, string prefix)
        {
            FileHelper.ValidateFile(file);
            _logger.LogInformation("Validated file. FileName: {FileName}, FileSize: {FileSize} bytes", file.FileName, file.Length);
            var uniqueFileName = FileHelper.GenerateUniqueFileName(file.FileName, prefix);
            Console.WriteLine(uniqueFileName);
            using var stream = file.OpenReadStream();
            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(uniqueFileName, stream),
                Folder = folder,
            };

            var uploadResult = await _cloudinary.UploadAsync(uploadParams);

            return uploadResult.SecureUrl.ToString();
        }

        public async Task DeleteImageAsync(string publicId)
        {
            try
            {
                if (string.IsNullOrEmpty(publicId))
                    throw new ArgumentNullException($"PublicId không được phép NULL!");
                var deleteParams = new DeletionParams(publicId);
                var result = await _cloudinary.DestroyAsync(deleteParams);

                if(result.Error != null)
                {
                    _logger.LogError($"Có lỗi sảy ra khi xóa hình ảnh với PublicId: {publicId}, Error: {result.Error.Message}");
                    throw new ArgumentNullException($"Không thể xóa một PublicId không tồn tại!");
                }
            }    
            catch(Exception ex)
            {
                _logger.LogError($"Không thể xóa hình ảnh với PUBLIC_ID: {publicId}");
                throw ex;
            }
        }
        
        public async Task<string> ReplaceImageAsync(IFormFile newFile,string oldPublicId, string folder, string prefix)
        {
            string newImageUrl = await UploadImageAsync(newFile, folder, prefix);

            if(!string.IsNullOrEmpty(oldPublicId))
                await DeleteImageAsync(oldPublicId);

            return newImageUrl;
        }

        public string GetPublicIdFromUrl(string imageUrl)
        {
            try
            {
                var uri = new Uri(imageUrl);
                
                var segments = uri.AbsolutePath.Split('/');
                
                var uploadIndex = Array.IndexOf(segments, "upload");
                if (uploadIndex == -1 || uploadIndex + 2 >= segments.Length)
                    return null;

                var startIndex = uploadIndex + 2;


                var publicId = string.Join("/", segments.Skip(startIndex)
                                                .Take(segments.Length - startIndex)).Replace(Path.GetExtension(segments.Last()), "");
                
                return publicId;
            } catch(Exception ex)
            {
                _logger.LogError("Có lỗi khi chuyển đổi Image URL sang PUBLIC_ID");
                return null;
            }
        }

        public async Task<UploadResult> UploadUserAvatarAsync(IFormFile file, string userId) {
            try {
                await _unitOfWork.BeginTransactionAsync();
                FileHelper.ValidateFile(file);
                _logger.LogInformation("Validated file for userId: {UserId}. FileName: {FileName}, FileSize: {FileSize} bytes", userId, file.FileName, file.Length);

                var user = await _unitOfWork.UserRepository.GetUserImageAsync(userId);
                if (user == null) {
                    _logger.LogWarning("User not found while uploading avatar. UserId: {UserId}", userId);
                    throw new UserNotFoundException(userId);
                }

                var uniqueFileName = FileHelper.GenerateUniqueFileName(file.FileName, CloudinaryConstants.FileTypes.UserAvatar);
                

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
                await _unitOfWork.CommitAsync();
                return uploadResult;
            } catch (Exception ex) {
                await _unitOfWork.RollbackAsync();
                _logger.LogError(ex, "Error uploading avatar for userId: {UserId}", userId);
                throw new Exception("Failed to upload user avatar", ex);
            }
        }

        public async Task<DeletionResult> DeleteUserAvatarAsync(string userId) {
            _logger.LogInformation("Started deleting avatar for userId: {userId}", userId);
            try {
                await _unitOfWork.BeginTransactionAsync();
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
               
                await _unitOfWork.CommitAsync();
                return result;
            } catch (Exception ex) {
                await _unitOfWork.RollbackAsync();
                _logger.LogError(ex, "Error deleting avatar for userId: {userId}", userId);
                throw new Exception("Failed to delete user avatar", ex);
            }
        }
    }
}
