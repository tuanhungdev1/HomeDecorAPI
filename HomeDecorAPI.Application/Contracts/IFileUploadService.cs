using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts {
    public interface IFileUploadService {
        Task<string> UploadAvatarFileAsync(IFormFile file);
    }
}
