using HomeDecorAPI.Application.DTOs.CategoryDto;
using HomeDecorAPI.Application.DTOs.CategoryDtos;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts {
    public interface ICategoryService {
        
        Task<(IEnumerable<CategoryDto> categories, MetaData metaData)> GetAllCategoriesAsync(CategoryRequestParameters categoryRequestParameters);
       
        Task<CategoryDto> GetCategoryByIdAsync(int categoryId);
       
        Task<CategoryDto> CreateCategoryAsync(CategoryForCreateDto categoryForCreateDto);
        
        Task<CategoryDto> UpdateCategoryAsync(int categoryId, CategoryForUpdateDto categoryForUpdateDto);
        
        Task DeleteCategoryAsync(int categoryId);
        
        Task<IEnumerable<CategoryDto>> GetSubCategoriesAsync(int parentCategoryId);
    }
}
