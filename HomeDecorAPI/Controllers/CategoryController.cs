using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.CategoryDtos;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.Constants;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using HomeDecorAPI.Application.Shared.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace HomeDecorAPI.Presentation.Controllers {
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase {
        private readonly ICategoryService _categoryService;
        private readonly ILogger<CategoryController> logger;

        public CategoryController(ICategoryService categoryService, ILogger<CategoryController> logger) {
            _categoryService = categoryService;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesAsync() {
            var categories = await _categoryService.GetAllCategoriesAsync();
            return Ok();
        }

        [HttpGet("{categoryId:int}")]
        public async Task<IActionResult> GetCategoryByIdAsync(int categoryId) {
            var category = await _categoryService.GetCategoryByIdAsync(categoryId);
            return Ok();
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateCategoryAsync([FromBody] CategoryForCreateDto categoryForCreateDto) {
            var category = await _categoryService.CreateCategoryAsync(categoryForCreateDto);
            return Created();
        }

        [HttpPut("{categoryId:int}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateCategoryAsync(int categoryId, [FromBody] CategoryForUpdateDto categoryForUpdateDto) {
            var category = await _categoryService.UpdateCategoryAsync(categoryId, categoryForUpdateDto);
            return Ok();
        }

        [HttpDelete("{categoryId:int}")]
        public async Task<IActionResult> DeleteCategoryAsync(int categoryId) {
            await _categoryService.DeleteCategoryAsync(categoryId);
            return Ok();
        }

        [HttpGet("{parentCategoryId:int}/subcategories")]
        public async Task<IActionResult> GetSubCategoriesAsync(int parentCategoryId) {
            var subCategories = await _categoryService.GetSubCategoriesAsync(parentCategoryId);
            return Ok();
        }
    }
}
