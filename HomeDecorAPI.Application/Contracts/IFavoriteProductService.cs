using HomeDecorAPI.Application.DTOs.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts {
    public interface IFavoriteProductService {
        Task<bool> AddProductAsync(string userId, int productId);
        Task<bool> RemoveFavoriteProductAsync(string userId, int productId);
        Task<bool> RemoveAllFavoriteProductAsync(string userId);
        Task<IEnumerable<ProductDto>> GetAllFavoriteProductsAsync(string userId);
    }
}
