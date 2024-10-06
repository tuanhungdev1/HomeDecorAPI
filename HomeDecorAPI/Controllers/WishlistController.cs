using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.WishlistDtos;
using HomeDecorAPI.Application.Shared.ActionFilters;
using Microsoft.AspNetCore.Mvc;

namespace HomeDecorAPI.Presentation.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class WishlistController : ControllerBase {

        private readonly IFavoriteProductService _favoriteProductService;

        public WishlistController(IFavoriteProductService favoriteProductService)
        {
           _favoriteProductService = favoriteProductService;
       }

        [HttpGet("all/{userId}")]
        public async Task<IActionResult> GetWishlistByUserId(string userId) {
            var result = await _favoriteProductService.GetAllProductToFavoritesAsync(userId);

            if(result == null) 
                return NotFound();

            return Ok();
        }


        [HttpDelete]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> RemoveProductForWishlist([FromBody] AddProductForWishlistDto addProductForWishlistDto) {
            await _favoriteProductService.RemoveProductToFavoritesAsync(addProductForWishlistDto.UserId, addProductForWishlistDto.ProductId);

           

            return Ok();
        }

        [HttpDelete("{userId}")]
        public async Task<IActionResult> RemoveAllProductForWishlist(string userId) {
            await _favoriteProductService.RemoveAllFavoriteProductAsync(userId);

           

            return Ok();

        }

    }
}
