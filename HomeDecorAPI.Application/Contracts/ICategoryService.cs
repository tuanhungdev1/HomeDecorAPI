using HomeDecorAPI.Application.DTOs.CategoryDto;
using HomeDecorAPI.Application.DTOs.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts {
    public interface ICategoryService {
        
        Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync();

       
        Task<CategoryDto> GetCategoryByIdAsync(int categoryId);

       
        Task<CategoryDto> CreateCategoryAsync(CategoryForCreateDto categoryForCreateDto);

        
        Task<CategoryDto> UpdateCategoryAsync(int categoryId, CategoryForUpdateDto categoryForUpdateDto);

        
        Task<bool> DeleteCategoryAsync(int categoryId);

        
        Task<IEnumerable<CategoryDto>> GetSubCategoriesAsync(int parentCategoryId);

        
        Task<bool> CategoryExistsAsync(int categoryId);
    }
}
