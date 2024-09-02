using HomeDecorAPI.Application.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace HomeDecorAPI.Presentation.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class WishlistController : ControllerBase {

        private readonly IServiceManager _serviceManager;

        public WishlistController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("user/{userId:Guid}")]
        public async Task<IActionResult> GetWishlistByUserId(Guid userId) {
            var result = await _serviceManager.FavoriteProductService.GetAllFavoriteProductsAsync(userId);


        }
    }
}
