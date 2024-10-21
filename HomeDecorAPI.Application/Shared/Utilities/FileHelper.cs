using HomeDecorAPI.Domain.Exceptions.BadRequestException;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.Utilities {
    public static class FileHelper {
        public static string GenerateUniqueFileName(string originalFileName, string prefix = "") {
            var extension = Path.GetExtension(originalFileName).ToLowerInvariant();

            var timestamp = DateTime.UtcNow.ToString("yyyyMMddHHmmss");
            var uniqueId = Guid.NewGuid().ToString("N").Substring(0, 8);

            return $"{prefix}_{timestamp}_{uniqueId}{extension}";
        }

        public static string SanitizeFileName(string fileName) {
            // Loại bỏ ký tự đặc biệt và khoảng trắng
            var invalidChars = Path.GetInvalidFileNameChars();
            var sanitizedName = String.Join("_", fileName.Split(invalidChars));

            // Chuyển về lowercase và thay thế khoảng trắng bằng gạch dưới
            return sanitizedName.ToLower().Replace(" ", "_");
        }

        public static void ValidateFile(IFormFile file) {
            if (file == null || file.Length == 0)
                throw new FileUploadBadRequestException("No file uploaded");

            
            if (file.Length > 10 * 1024 * 1024)
                throw new FileUploadBadRequestException("File size exceeds maximum limit of 10MB");

            // Validate file type
            var allowedTypes = new[] { "image/jpeg", "image/jpg", "image/png" };
            if (!allowedTypes.Contains(file.ContentType.ToLower()))
                throw new FileUploadBadRequestException("Invalid file type. Only JPEG and PNG are allowed");
        }
    }
}
