using HomeDecorAPI.Application.DTOs.ProductDtos;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts {
    public interface IProductService {
        Task<(IEnumerable<ProductDto>, MetaData)> GetAllProductsAsync(int pageNumber, int pageSize);
        Task<ProductDto> GetProductByIdAsync(int productId);
        Task<ProductDto> CreateProductAsync(ProductForCreateDto productForCreateDto);
        Task<ProductDto> UpdateProductAsync(int productId, ProductForUpdateDto productForUpdateDto);
        Task DeleteProductAsync(int productId);
        //Task<IEnumerable<ProductDto>> GetProductsByCategoryAsync(int categoryId);   
    
    }
}
