using HomeDecorAPI.Application.Shared.ResponseFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.Utilities {
    public static class ApiResponseFactory {
        public static ApiResponse<T> CreateResponse<T>(bool isSuccess, string message, T data = default, List<string> errors = null) {
            return new ApiResponse<T>(
                isSuccess: isSuccess,
                message: message,
                data: data,
                errors: errors
                );
        }
    }
}
