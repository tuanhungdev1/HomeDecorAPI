using HomeDecorAPI.Application.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace HomeDecorAPI.Presentation.Controllers {
    [Route("api/token")]
    [ApiController]
    public class TokenController : ControllerBase {
        private readonly IServiceManager _service;
        public TokenController(IServiceManager service) => _service = service;
    }
}
