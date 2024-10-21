using CloudinaryDotNet.Actions;
using HomeDecorAPI.Application.Shared.Constants;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts {
    public interface ICloudinaryService {
        Task<UploadResult> UploadUserAvatarAsync(IFormFile file, string userId);
        Task<DeletionResult> DeleteUserAvatarAsync(string userId);
        Task<string> UploadImageAsync(IFormFile file, string folder, string prefix);
        Task DeleteImageAsync(string publicId);
        Task<string> ReplaceImageAsync(IFormFile newFile, string oldPublicId, string folder, string prefix);
        string GetPublicIdFromUrl(string imageUrl);
    }
}
