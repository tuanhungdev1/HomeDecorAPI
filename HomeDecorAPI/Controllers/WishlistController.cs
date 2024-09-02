using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.WishlistDtos;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.Constants;
using HomeDecorAPI.Application.Shared.Messages;
using HomeDecorAPI.Application.Shared.Utilities;
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

        [HttpGet("all/{userId}")]
        public async Task<IActionResult> GetWishlistByUserId(string userId) {
            var result = await _serviceManager.FavoriteProductService.GetAllFavoriteProductsAsync(userId);

            if(result == null) 
                return NotFound(ApiResponseFactory.CreateResponse<object>(false, ErrorMessages.Entity.NotFound("User", userId)));

            return Ok(ApiResponseFactory.CreateResponse(true, SuccessMessages.Entity.ListRetrieved("Wishlist"), result));
        }


        [HttpDelete]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> RemoveProductForWishlist([FromBody] AddProductForWishlistDto addProductForWishlistDto) {
            var result = await _serviceManager.FavoriteProductService.RemoveFavoriteProductAsync(addProductForWishlistDto.UserId, addProductForWishlistDto.ProductId);

            if(!result) {
                return BadRequest(ApiResponseFactory.CreateResponse<object>(false, ErrorMessages.Entity.ItemNotFound("Wishlist", addProductForWishlistDto.ProductId.ToString(), addProductForWishlistDto.UserId.ToString())));
            }

            return Ok(ApiResponseFactory.CreateResponse<object>(true, SuccessMessages.Entity.ItemRemoved(addProductForWishlistDto.ProductId.ToString(), "Wishlist", addProductForWishlistDto.UserId.ToString())));
        }

        [HttpDelete("{userId}")]
        public async Task<IActionResult> RemoveAllProductForWishlist(string userId) {
            var result = await _serviceManager.FavoriteProductService.RemoveAllFavoriteProductAsync(userId);

            if (!result) {
                return BadRequest(ApiResponseFactory.CreateResponse<object>(false, ErrorMessages.Entity.ItemDeletionFailed("Wishlist", userId.ToString())));
            }

            return Ok(ApiResponseFactory.CreateResponse<object>(true, SuccessMessages.Entity.AllItemsDeleted("Wishlist")));

        }

    }
}
