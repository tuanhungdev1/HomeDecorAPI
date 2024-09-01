using HomeDecorAPI.Application.DTOs.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts {
    public interface IFavoriteProductService {
        Task<bool> AddProductAsync(Guid userId, int productId);
        Task<bool> RemoveFavoriteProductAsync(Guid userId, int productId);
        Task<bool> RemoveAllFavoriteProductAsync(Guid userId);
        Task<IEnumerable<ProductDto>> GetAllFavoriteProductsAsync(Guid userId);
    }
}
