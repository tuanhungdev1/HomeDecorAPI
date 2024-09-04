using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Services.Cart
{
    public interface ICartService
    {
        Task<bool> AddItemToCartAsync(string userId, int productId);
        Task<bool> RemoveItemToCartAsync(string userId, int productId);
        Task<bool> RemoveAllItemToCartAsync(string userId);
    }
}
