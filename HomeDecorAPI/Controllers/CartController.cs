using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.CartDtos;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using HomeDecorAPI.Application.Shared.Utilities;
using HomeDecorAPI.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HomeDecorAPI.API.Controllers {
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase {
        private readonly IServiceManager _serviceManager;

        public CartController(IServiceManager serviceManager) {
            _serviceManager = serviceManager;
        }

        private string GetUserId() {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }

        [HttpGet]
        public async Task<ActionResult<CartDto>> GetCart() {
            var userId = GetUserId();
            var cart = await _serviceManager.CartService.GetCartByUserIdAsync(userId);

            var apiResponse = ApiResponseFactory.CreateResponse<CartDto>(true, $"Get Cart for UserID:{userId} is successfully.", cart);
            return Ok(apiResponse);
        }

        [HttpGet("items")]
        public async Task<ActionResult<IEnumerable<CartItemDto>>> GetCartItems() {
            var userId = GetUserId();
            var cartItems = await _serviceManager.CartService.GetAllCartItemsForUserAsync(userId);
            var apiResponse = ApiResponseFactory.CreateResponse<IEnumerable<CartItemDto>>(true, $"Get CartItems for UserID:{userId} is successfully.", cartItems);

            return Ok(apiResponse);
        }

        [HttpPost("add")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> AddToCart([FromBody] AddToCartDto addToCartDto) {
            var userId = GetUserId();
            await _serviceManager.CartService.AddProductToCartAsync(userId, addToCartDto);

            var apiResponse = ApiResponseFactory.CreateResponse<object>(true, $"Add product to Cart for UserID:{userId} is successfully.");
            return Ok(apiResponse);
        }

        [HttpDelete("remove/{cartItemId}")]
        public async Task<IActionResult> RemoveFromCart(int cartItemId) {
            var userId = GetUserId();
            await _serviceManager.CartService.RemoveProductFromCartAsync(userId, cartItemId);
            var apiResponse = ApiResponseFactory.CreateResponse<object>(true, $"Remove product from Cart for UserID:{userId} is successfully.");
            return Ok(apiResponse);
        }

        [HttpDelete("clear")]
        public async Task<IActionResult> ClearCart() {
            var userId = GetUserId();
            await _serviceManager.CartService.ClearCartAsync(userId);
            var apiResponse = ApiResponseFactory.CreateResponse<object>(true, $"Clear all product from Cart for UserID:{userId} is successfully.");
            return Ok(apiResponse);
            
        }

        [HttpPut("update-quantity")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateQuantity([FromBody] UpdateCartItemQuantityDto updateDto) {
            var userId = GetUserId();
            await _serviceManager.CartService.UpdateCartItemQuantityAsync(userId, updateDto.CartItemId, updateDto.NewQuantity);
            var apiResponse = ApiResponseFactory.CreateResponse<object>(true, $"Update quantity product from Cart for UserID:{userId} is successfully.");
            return Ok(apiResponse);
        }

        [HttpPut("update-shipping")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateShippingCost([FromBody] UpdateShippingCostDto updateDto) {
            var userId = GetUserId();
            await _serviceManager.CartService.UpdateCartShippingCostAsync(userId, updateDto.ShippingCost);
            var apiResponse = ApiResponseFactory.CreateResponse<object>(true, $"Update shipping cost for Cart is successfully.");
            return Ok(apiResponse);
        }

        [HttpPut("apply-discount")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> ApplyDiscount([FromBody] ApplyDiscountDto discountDto) {
            var userId = GetUserId();
            await _serviceManager.CartService.ApplyDiscountAsync(userId, discountDto.DiscountAmount);
            var apiResponse = ApiResponseFactory.CreateResponse<object>(true, $"Apply discount for Cart is successfully.");
            return Ok(apiResponse);
        }
    }
}