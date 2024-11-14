using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.CategoryDto;
using HomeDecorAPI.Application.DTOs.CategoryDtos;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.Constants;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using HomeDecorAPI.Application.Shared.Utilities;
using HomeDecorAPI.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HomeDecorAPI.Presentation.Controllers {
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase {
        private readonly ICategoryService _categoryService;
        private readonly ILoggerService _logger;

        public CategoryController(ICategoryService categoryService, ILoggerService logger) {
            _categoryService = categoryService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesAsync([FromQuery] CategoryRequestParameters categoryRequestParameters) {
            var categoriesResult = await _categoryService.GetAllCategoriesAsync(categoryRequestParameters);
            _logger.LogInfo("Lấy dữ liệu thông tin Category thành công.");
            Response.AddPaginationHeader(categoriesResult.metaData);
            return Ok(new ApiResponse<IEnumerable<CategoryDto>>
            {
                StatusCode = 200,
                Success = true,
                Message = "Lấy dữ liệu Category thành công.",
                Data = categoriesResult.categories
            });
        }

        [HttpGet("{categoryId:int}")]
        public async Task<IActionResult> GetCategoryByIdAsync(int categoryId) {
            var category = await _categoryService.GetCategoryByIdAsync(categoryId);
            _logger.LogInfo($"Lấy dữ liệu Category với ID: {categoryId} thành công.");
            return Ok(new ApiResponse<CategoryDto>
            {
                StatusCode = 200,
                Success = true,
                Message = $"Lấy dữ liệu Category với ID:{categoryId} thành công.",
                Data = category
            });
        }
        //[Authorize(Roles = "Admin")]
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateCategoryAsync([FromBody] CategoryForCreateDto categoryForCreateDto) {
            var category = await _categoryService.CreateCategoryAsync(categoryForCreateDto);
            _logger.LogInfo($"Tạo thành công một Category mới");
            return StatusCode(StatusCodes.Status201Created, new ApiResponse<object>
            {
                Success = true,
                StatusCode = 201,
                Data = category,
                Message = "Tạo thành công một Category mới."
            });
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{categoryId:int}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateCategoryAsync(int categoryId, [FromBody] CategoryForUpdateDto categoryForUpdateDto) {
            var category = await _categoryService.UpdateCategoryAsync(categoryId, categoryForUpdateDto);
            _logger.LogInfo($"Cập nhật thành công Category với ID: {categoryId}");
            return Ok(new ApiResponse<CategoryDto>
            {
                StatusCode = 200,
                Success = true,
                Message = $"Cập nhật thành công Category với ID: {categoryId}",
                Data = category
            });
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{categoryId:int}")]
        public async Task<IActionResult> DeleteCategoryAsync(int categoryId) {
            await _categoryService.DeleteCategoryAsync(categoryId);
            _logger.LogInfo($"Xóa thành công một Category với ID: {categoryId}");
            return Ok(new ApiResponse<object>
            {
                Success= true,
                StatusCode = 200,
                Message = $"Xóa thành công một Category với ID: {categoryId}"
            });
        }



        [HttpGet("{parentCategoryId:int}/subcategories")]
        public async Task<IActionResult> GetSubCategoriesAsync(int parentCategoryId) {
            var subCategories = await _categoryService.GetSubCategoriesAsync(parentCategoryId);
            _logger.LogInfo($"Lấy thành công danh sách các SubCategories của ParentCategory với ID: {parentCategoryId}");
            return Ok(new ApiResponse<IEnumerable<CategoryDto>>
            {
                Success = true,
                StatusCode = 200,
                Message = $"Lấy thành công danh sách các SubCategories của ParentCategory với ID: {parentCategoryId}",
                Data = subCategories
            });
        }
    }
}
