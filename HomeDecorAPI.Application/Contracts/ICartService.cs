using HomeDecorAPI.Application.DTOs.CartDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts
{
    public interface ICartService
    {
        Task<CartDto> GetCartByUserIdAsync(string userId);
        Task<IEnumerable<CartItemDto>> GetAllCartItemsForUserAsync(string userId);
        Task AddProductToCartAsync(string userId, AddToCartDto addToCartDto);
        Task RemoveProductFromCartAsync(string userId, int cartItemId);
        Task ClearCartAsync(string userId);
        Task UpdateCartItemQuantityAsync(string userId, int cartItemId, int newQuantity);
        Task UpdateCartShippingCostAsync(string userId, decimal shippingCost);
        Task ApplyDiscountAsync(string userId, decimal discountAmount);
    }
}