using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.ResponseFeatures {
    public class ApiResponse<T> {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public List<string> Errors { get; set; }
        public int StatusCode { get; set; }

        public ApiResponse()
        {
            Success = true;
            Message = string.Empty;
            Errors = new List<string>();
        }
    }

}
