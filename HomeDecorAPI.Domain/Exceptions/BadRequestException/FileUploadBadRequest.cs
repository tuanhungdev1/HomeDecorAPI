using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.BadRequestException {
    public class FileUploadBadRequest : BadRequestException {
        public FileUploadBadRequest() : base("File to large")
        {
            
        }
    }
}
