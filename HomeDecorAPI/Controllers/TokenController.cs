using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.TokenDtos;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace HomeDecorAPI.Presentation.Controllers {
    [Route("api/token")]
    [ApiController]
    public class TokenController : ControllerBase {
        private readonly IAuthenticationService _authenticationService;
        public TokenController(IAuthenticationService service) => _authenticationService = service;

        [HttpPost("refresh")]

        public async Task<IActionResult> Refresh([FromBody] TokenDto tokenDto) {
            var tokenDtoToReturn = await _authenticationService.RefreshToken(tokenDto);
            return Ok(new AuthResponse<TokenDto> {
                    Success = true,
                    Message = "Refresh token successfully.",
                    Data = new TokenDto {
                        AccessToken = tokenDto.AccessToken,
                        RefreshToken = tokenDto.RefreshToken,
                    }
                });
        }
    }
}
