using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.CartDtos;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using HomeDecorAPI.Domain.Exceptions;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using HomeDecorAPI.Domain.Exceptions.UnauthorizedException;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HomeDecorAPI.API.Controllers {
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase {
        private readonly ICartService _cartService;
        private readonly ILogger<CartController> _logger;

        public CartController(ICartService cartService, ILogger<CartController> logger) {
            _cartService = cartService ?? throw new ArgumentNullException(nameof(cartService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        private string GetUserId() {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId)) {
                throw new UserUnauthorizedException("User ID not found in claims");
            }
            return userId;
        }

        [HttpGet]
        [ProducesResponseType(typeof(ApiResponse<CartDto>), 200)]
        [ProducesResponseType(typeof(ApiResponse<object>), 400)]
        [ProducesResponseType(typeof(ApiResponse<object>), 404)]
        public async Task<ActionResult<ApiResponse<CartDto>>> GetCart() {
            try {
                _logger.LogInformation("Getting cart for user");
                var userId = GetUserId();

                var cart = await _cartService.GetCartByUserIdAsync(userId);

                var response = new ApiResponse<CartDto> {
                    Success = true,
                    Data = cart,
                    Message = "Cart retrieved successfully",
                    StatusCode = StatusCodes.Status200OK
                };

                _logger.LogInformation("Successfully retrieved cart for user {UserId}", userId);
                return Ok(response);
            } catch (NotFoundException ex) {
                _logger.LogWarning(ex, "Cart not found for user");
                return NotFound(new ApiResponse<object> {
                    Success = false,
                    Message = ex.Message,
                    StatusCode = StatusCodes.Status404NotFound
                });
            } catch (Exception ex) {
                _logger.LogError(ex, "Error occurred while getting cart");
                return BadRequest(new ApiResponse<object> {
                    Success = false,
                    Message = "An error occurred while processing your request",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
        }

        [HttpGet("items")]
        [ProducesResponseType(typeof(ApiResponse<IEnumerable<CartItemDto>>), 200)]
        public async Task<ActionResult<ApiResponse<IEnumerable<CartItemDto>>>> GetCartItems() {
            try {
                var userId = GetUserId();
                _logger.LogInformation("Getting cart items for user {UserId}", userId);

                var cartItems = await _cartService.GetAllCartItemsForUserAsync(userId);

                var response = new ApiResponse<IEnumerable<CartItemDto>> {
                    Success = true,
                    Data = cartItems,
                    Message = "Cart items retrieved successfully",
                    StatusCode = StatusCodes.Status200OK
                };

                _logger.LogInformation("Successfully retrieved {Count} cart items for user {UserId}",
                    cartItems?.Count() ?? 0, userId);
                return Ok(response);
            } catch (Exception ex) {
                _logger.LogError(ex, "Error occurred while getting cart items");
                return BadRequest(new ApiResponse<object> {
                    Success = false,
                    Message = "An error occurred while retrieving cart items",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
        }

        [HttpPost("add")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ProducesResponseType(typeof(ApiResponse<object>), 200)]
        public async Task<ActionResult<ApiResponse<object>>> AddToCart([FromBody] AddToCartDto addToCartDto) {
            try {
                var userId = GetUserId();
                _logger.LogInformation("Adding product to cart for user {UserId}", userId);

                await _cartService.AddProductToCartAsync(userId, addToCartDto);

                var response = new ApiResponse<object> {
                    Success = true,
                    Message = "Product added to cart successfully",
                    StatusCode = StatusCodes.Status200OK
                };

                _logger.LogInformation("Successfully added product to cart for user {UserId}", userId);
                return Ok(response);
            } catch (Exception ex) {
                _logger.LogError(ex, "Error occurred while adding product to cart");
                return BadRequest(new ApiResponse<object> {
                    Success = false,
                    Message = "An error occurred while adding product to cart",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
        }

        [HttpDelete("remove/{cartItemId}")]
        [ProducesResponseType(typeof(ApiResponse<object>), 200)]
        public async Task<ActionResult<ApiResponse<object>>> RemoveFromCart(int cartItemId) {
            try {
                var userId = GetUserId();
                _logger.LogInformation("Removing item {CartItemId} from cart for user {UserId}",
                    cartItemId, userId);

                await _cartService.RemoveProductFromCartAsync(userId, cartItemId);

                var response = new ApiResponse<object> {
                    Success = true,
                    Message = "Product removed from cart successfully",
                    StatusCode = StatusCodes.Status200OK
                };

                _logger.LogInformation("Successfully removed item {CartItemId} from cart for user {UserId}",
                    cartItemId, userId);
                return Ok(response);
            } catch (NotFoundException ex) {
                _logger.LogWarning(ex, "Cart item not found");
                return NotFound(new ApiResponse<object> {
                    Success = false,
                    Message = ex.Message,
                    StatusCode = StatusCodes.Status404NotFound
                });
            } catch (Exception ex) {
                _logger.LogError(ex, "Error occurred while removing product from cart");
                return BadRequest(new ApiResponse<object> {
                    Success = false,
                    Message = "An error occurred while removing product from cart",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
        }

        [HttpDelete("clear")]
        [ProducesResponseType(typeof(ApiResponse<object>), 200)]
        public async Task<ActionResult<ApiResponse<object>>> ClearCart() {
            try {
                var userId = GetUserId();
                _logger.LogInformation("Clearing cart for user {UserId}", userId);

                await _cartService.ClearCartAsync(userId);

                var response = new ApiResponse<object> {
                    Success = true,
                    Message = "Cart cleared successfully",
                    StatusCode = StatusCodes.Status200OK
                };

                _logger.LogInformation("Successfully cleared cart for user {UserId}", userId);
                return Ok(response);
            } catch (Exception ex) {
                _logger.LogError(ex, "Error occurred while clearing cart");
                return BadRequest(new ApiResponse<object> {
                    Success = false,
                    Message = "An error occurred while clearing cart",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
        }

        [HttpPut("update-quantity")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ProducesResponseType(typeof(ApiResponse<object>), 200)]
        public async Task<ActionResult<ApiResponse<object>>> UpdateQuantity([FromBody] UpdateCartItemQuantityDto updateDto) {
            try {
                var userId = GetUserId();
                _logger.LogInformation("Updating quantity for cart item {CartItemId} for user {UserId}",
                    updateDto.CartItemId, userId);

                await _cartService.UpdateCartItemQuantityAsync(userId, updateDto.CartItemId, updateDto.NewQuantity);

                var response = new ApiResponse<object> {
                    Success = true,
                    Message = "Cart item quantity updated successfully",
                    StatusCode = StatusCodes.Status200OK
                };

                _logger.LogInformation("Successfully updated quantity for cart item {CartItemId} for user {UserId}",
                    updateDto.CartItemId, userId);
                return Ok(response);
            } catch (NotFoundException ex) {
                _logger.LogWarning(ex, "Cart item not found during quantity update");
                return NotFound(new ApiResponse<object> {
                    Success = false,
                    Message = ex.Message,
                    StatusCode = StatusCodes.Status404NotFound
                });
            } catch (Exception ex) {
                _logger.LogError(ex, "Error occurred while updating cart item quantity");
                return BadRequest(new ApiResponse<object> {
                    Success = false,
                    Message = "An error occurred while updating cart item quantity",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
        }

        [HttpPut("update-shipping")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ProducesResponseType(typeof(ApiResponse<object>), 200)]
        public async Task<ActionResult<ApiResponse<object>>> UpdateShippingCost([FromBody] UpdateShippingCostDto updateDto) {
            try {
                var userId = GetUserId();
                _logger.LogInformation("Updating shipping cost for user {UserId}", userId);

                await _cartService.UpdateCartShippingCostAsync(userId, updateDto.ShippingCost);

                var response = new ApiResponse<object> {
                    Success = true,
                    Message = "Shipping cost updated successfully",
                    StatusCode = StatusCodes.Status200OK
                };

                _logger.LogInformation("Successfully updated shipping cost for user {UserId}", userId);
                return Ok(response);
            } catch (Exception ex) {
                _logger.LogError(ex, "Error occurred while updating shipping cost");
                return BadRequest(new ApiResponse<object> {
                    Success = false,
                    Message = "An error occurred while updating shipping cost",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
        }

        [HttpPut("apply-discount")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ProducesResponseType(typeof(ApiResponse<object>), 200)]
        public async Task<ActionResult<ApiResponse<object>>> ApplyDiscount([FromBody] ApplyDiscountDto discountDto) {
            try {
                var userId = GetUserId();
                _logger.LogInformation("Applying discount for user {UserId}", userId);

                await _cartService.ApplyDiscountAsync(userId, discountDto.DiscountAmount);

                var response = new ApiResponse<object> {
                    Success = true,
                    Message = "Discount applied successfully",
                    StatusCode = StatusCodes.Status200OK
                };

                _logger.LogInformation("Successfully applied discount for user {UserId}", userId);
                return Ok(response);
            } catch (InvalidOperationException ex) {
                _logger.LogWarning(ex, "Invalid discount operation");
                return BadRequest(new ApiResponse<object> {
                    Success = false,
                    Message = ex.Message,
                    StatusCode = StatusCodes.Status400BadRequest
                });
            } catch (Exception ex) {
                _logger.LogError(ex, "Error occurred while applying discount");
                return BadRequest(new ApiResponse<object> {
                    Success = false,
                    Message = "An error occurred while applying discount",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }
        }
    }
}