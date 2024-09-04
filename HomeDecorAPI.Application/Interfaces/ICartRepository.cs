using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeDecorAPI.Domain.Entities;

namespace HomeDecorAPI.Application.Interfaces {
    public interface ICartRepository : IRepositoryBase<Cart> {
        Task<IEnumerable<CartItem>> GetAllCartItemForUserAsync(string userId);
        Task<bool> IsProductInCartAsync(string userId, int productId);
        Task IncrementQuantityForProductInCart(string userId, int productId);
    }
}
