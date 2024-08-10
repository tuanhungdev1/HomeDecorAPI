using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.ResponseFeatures {
    public class ApiResponse<T> {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public List<string> Errors { get; set; }

        public ApiResponse() {
            Errors = new List<string>();
        }

        public ApiResponse(bool isSuccess, string message, T data = default, List<string> errors = null) {
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
            Errors = errors ?? new List<string>();
        }
    }

}
