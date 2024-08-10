using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using Microsoft.AspNetCore.Mvc;

namespace HomeDecorAPI.Presentation.Controllers {
    [Route("api/auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase {
        private readonly IServiceManager _service;
        public AuthenticationController(IServiceManager service) => _service = service;


        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistrationDto) {
            var result = await _service.AuthenticationService.RegisterUser(userForRegistrationDto);

            if (!result.Succeeded) {
                foreach (var error in result.Errors) {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }

                return BadRequest(ModelState);
            }

            return StatusCode(201);
        }
    }

}
