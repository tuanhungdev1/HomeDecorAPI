using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.Shared.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeDecorAPI.Domain.Entities;

namespace HomeDecorAPI.Application.Services {
    public class FileUploadService : IFileUploadService {
        
        private readonly long _fileSizeLimit = 2 * 1024 * 1024; // 2MB
        private readonly string[] _permittedExtensions = { ".png", ".jpg", ".jepg" };
        private readonly UserManager<User> _userManager;

        public FileUploadService(UserManager<User> userManager)
        {
           _userManager = userManager;
        }

        public async Task UploadAvatarFileAsync(IFormFile formFile) {
            // Kiểm tra kích thước file
            
        }
    }
}
