using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.DTOs.TokenDtos {
    public record TokenDto(string AccessToken, string RefreshToken);
}
