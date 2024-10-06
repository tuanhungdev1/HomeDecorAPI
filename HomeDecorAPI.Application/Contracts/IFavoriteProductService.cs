using HomeDecorAPI.Application.DTOs.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts {
    public interface IFavoriteProductService {
        Task AddProductToFavoritesAsync(string userId, int productId);
        Task RemoveProductToFavoritesAsync(string userId, int productId);
        Task RemoveAllFavoriteProductAsync(string userId);
        Task<IEnumerable<ProductDto>> GetAllProductToFavoritesAsync(string userId);
    }
}
