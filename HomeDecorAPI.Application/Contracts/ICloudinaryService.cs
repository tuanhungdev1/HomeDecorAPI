using CloudinaryDotNet.Actions;
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
    }
}
