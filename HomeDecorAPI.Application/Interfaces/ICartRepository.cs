using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeDecorAPI.Domain.Entities;

namespace HomeDecorAPI.Application.Interfaces {
    public interface ICartRepository : IRepositoryBase<Cart> {
        Task<Cart> GetCartByUserIdAsync(string userId);
        Task<IEnumerable<CartItem>> GetAllCartItemForUserAsync(string userId);
        Task AddProductToCartAsync(string userId, int productId, int quantity);
        Task RemoveProductFromCartAsync(string userId, int cartItemId);
        Task ClearCartAsync(string userId);
        Task ApplyDiscountAsync(string userId, decimal discountAmount);
        Task UpdateCartShippingCostAsync(string userId, decimal shippingCost);
        Task UpdateCartItemQuantityAsync(string userId, int cartItemId, int newQuantity);
        Task<bool> CheckProductStockAsync(int productId, int quantity);
    }
}
