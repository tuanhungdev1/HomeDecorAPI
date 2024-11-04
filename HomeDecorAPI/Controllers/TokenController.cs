using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.TokenDtos;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using HomeDecorAPI.Domain.Exceptions.BadRequestException;
using Microsoft.AspNetCore.Mvc;

namespace HomeDecorAPI.Presentation.Controllers {
    [Route("api/token")]
    [ApiController]
    public class TokenController : ControllerBase {
        private readonly IAuthenticationService _authenticationService;
        private readonly ILogger<TokenController> _logger;

        public TokenController(IAuthenticationService service, ILogger<TokenController> logger) {
            _authenticationService = service ?? throw new ArgumentNullException(nameof(service));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpPost("refresh")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Refresh([FromBody] TokenDto tokenDto) {
            try {
                var tokenDtoToReturn = await _authenticationService.RefreshToken(tokenDto);

                _logger.LogInformation("Token refreshed successfully");

                return Ok(new AuthResponse<TokenDto> {
                    Success = true,
                    Message = "Refresh token successful.",
                    Data = tokenDtoToReturn
                });
            
            } catch (Exception ex) {
                _logger.LogError(ex, "An error occurred while refreshing token");
                return StatusCode(401, new AuthResponse<TokenDto> {
                    Success = false,
                    Message = "Token Invalid" 
                });
            }
        }
    }
}