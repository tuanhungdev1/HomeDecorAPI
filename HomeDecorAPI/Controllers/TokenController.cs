using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.TokenDtos;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using Microsoft.AspNetCore.Mvc;

namespace HomeDecorAPI.Presentation.Controllers {
    [Route("api/token")]
    [ApiController]
    public class TokenController : ControllerBase {
        private readonly IServiceManager _service;
        public TokenController(IServiceManager service) => _service = service;

        [HttpPost("refresh")]

        public async Task<IActionResult> Refresh([FromBody] TokenDto tokenDto) {
            var tokenDtoToReturn = await _service.AuthenticationService.RefreshToken(tokenDto);
            return Ok(new AuthResponse<object>(
                    isSuccess: true,
                    message: "Refresh token successfully.",
                    token: tokenDtoToReturn.AccessToken,
                    refreshToken: tokenDtoToReturn.RefreshToken
                ));
        }
    }
}
