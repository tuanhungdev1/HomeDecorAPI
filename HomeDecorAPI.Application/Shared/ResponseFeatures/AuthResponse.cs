using HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.ResponseFeatures {
    public class AuthResponse<T> : ApiResponse<T> {
        public string Token { get; set; }
        public string RefreshToken { get; set; }

        public AuthResponse(bool isSuccess, string message, T data, string token, string refreshToken, List<string> errors = null)
            : base(isSuccess, message, data, errors) {
            Token = token;
            RefreshToken = refreshToken;
        }
    }
    

}
