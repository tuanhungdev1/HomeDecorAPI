using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.CartDtos;
using HomeDecorAPI.Application.Interfaces;
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
            return Ok(cart);
        }

        [HttpGet("items")]
        public async Task<ActionResult<IEnumerable<CartItemDto>>> GetCartItems() {
            var userId = GetUserId();
            var cartItems = await _serviceManager.CartService.GetAllCartItemsForUserAsync(userId);
            return Ok(cartItems);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddToCart([FromBody] AddToCartDto addToCartDto) {
            var userId = GetUserId();
            await _serviceManager.CartService.AddProductToCartAsync(userId, addToCartDto);
            return Ok();
        }

        [HttpDelete("remove/{cartItemId}")]
        public async Task<IActionResult> RemoveFromCart(int cartItemId) {
            var userId = GetUserId();
            await _serviceManager.CartService.RemoveProductFromCartAsync(userId, cartItemId);
            return Ok();
        }

        [HttpDelete("clear")]
        public async Task<IActionResult> ClearCart() {
            var userId = GetUserId();
            await _serviceManager.CartService.ClearCartAsync(userId);
            return Ok();
        }

        [HttpPut("update-quantity")]
        public async Task<IActionResult> UpdateQuantity([FromBody] UpdateCartItemQuantityDto updateDto) {
            var userId = GetUserId();
            await _serviceManager.CartService.UpdateCartItemQuantityAsync(userId, updateDto.CartItemId, updateDto.NewQuantity);
            return Ok();
        }

        [HttpPut("update-shipping")]
        public async Task<IActionResult> UpdateShippingCost([FromBody] UpdateShippingCostDto updateDto) {
            var userId = GetUserId();
            await _serviceManager.CartService.UpdateCartShippingCostAsync(userId, updateDto.ShippingCost);
            return Ok();
        }

        [HttpPut("apply-discount")]
        public async Task<IActionResult> ApplyDiscount([FromBody] ApplyDiscountDto discountDto) {
            var userId = GetUserId();
            await _serviceManager.CartService.ApplyDiscountAsync(userId, discountDto.DiscountAmount);
            return Ok();
        }
    }
}