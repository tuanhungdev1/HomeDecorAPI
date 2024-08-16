using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.Shared.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Services {
    public class CloudinaryFileUploadService : IFileUploadService {
        private readonly Cloudinary _cloudinary;

        public CloudinaryFileUploadService(IOptions<CloudinarySettings> config)
        {
            var acc = new Account(
                    config.Value.CloudName,
                    config.Value.ApiKey,
                    config.Value.ApiSecret
                );            

            _cloudinary = new Cloudinary( acc );
        }

        public async Task<string> UploadAvatarFileAsync(IFormFile file) {
            if (file.Length > 0) {
                using var stream = file.OpenReadStream();
                var uploadParams = new ImageUploadParams {
                    File = new FileDescription(file.FileName, stream),
                    Transformation = new Transformation().Width(500).Height(500).Crop("fill").Gravity("face")
                };

                var uploadResult = await _cloudinary.UploadAsync(uploadParams);

                if (uploadResult.Error != null) {
                    throw new Exception(uploadResult.Error.Message);    
                }

                return uploadResult.SecureUrl.ToString();
            }

            return null;
        }
    }
}
