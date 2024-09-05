using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeDecorAPI.Domain.Entities;

namespace HomeDecorAPI.Application.Interfaces {
    public interface ICartRepository : IRepositoryBase<Cart> {
        Task<Cart> GetCartByUserIdAsync(int userId);
        Task<IEnumerable<CartItem>> GetAllCartItemForUserAsync(string userId);
        Task AddProductToCartAsync(string userId, int productId, CartItem cartItem);
        Task RemoveProductFromCartAsync(string userId, int cartItemId);
        Task ClearProductInCartAsync(string userId);
        Task IncreaseProductQuantityAsync(string userId, int cartItemId, int amount);
        Task DecreaseProductQuantityAsync(string userId, int cartItemId, int amount);
    }
}
