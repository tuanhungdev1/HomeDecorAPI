using HomeDecorAPI.Application.Shared.RequestFeatures;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.Utilities {
    public static class HttpResponseExtensions {
        public static void AddPaginationHeader(this HttpResponse response, MetaData paginationMetadata) {
            var options = new JsonSerializerOptions {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            response.Headers.Add("X-Pagination", JsonSerializer.Serialize(paginationMetadata, options));
      }
    }
}
