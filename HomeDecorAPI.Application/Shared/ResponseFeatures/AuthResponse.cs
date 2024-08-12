using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.ResponseFeatures {
    public class AuthResponse<T> : ApiResponse<T> {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Token { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? RefreshToken { get; set; }

        public AuthResponse(bool isSuccess, string message, T? data = default, string? token = null, string? refreshToken = null, List<string>? errors = null)
            : base(isSuccess, message, data, errors) {
            Token = token;
            RefreshToken = refreshToken;
        }
    }


}
