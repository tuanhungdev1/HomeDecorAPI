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
        private readonly IServiceManager _serviceManager;

        public CategoryController(IServiceManager serviceManager) {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesAsync() {
            var categories = await _serviceManager.CategoryService.GetAllCategoriesAsync();
            return Ok(ApiResponseFactory.CreateResponse(true, Messages.Success.DataRetrieved, categories));
        }

        [HttpGet("{categoryId:int}")]
        public async Task<IActionResult> GetCategoryByIdAsync(int categoryId) {
            var category = await _serviceManager.CategoryService.GetCategoryByIdAsync(categoryId);
            return Ok(ApiResponseFactory.CreateResponse(true, Messages.Success.DataRetrieved, category));
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateCategoryAsync([FromBody] CategoryForCreateDto categoryForCreateDto) {
            var category = await _serviceManager.CategoryService.CreateCategoryAsync(categoryForCreateDto);
            return StatusCode(StatusCodes.Status201Created, ApiResponseFactory.CreateResponse(true, Messages.Success.EntityCreated.Replace("{0}", "Category"), category));
        }

        [HttpPut("{categoryId:int}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateCategoryAsync(int categoryId, [FromBody] CategoryForUpdateDto categoryForUpdateDto) {
            var category = await _serviceManager.CategoryService.UpdateCategoryAsync(categoryId, categoryForUpdateDto);
            return Ok(ApiResponseFactory.CreateResponse(true, Messages.Success.EntityUpdated.Replace("{0}", "Category"), category));
        }

        [HttpDelete("{categoryId:int}")]
        public async Task<IActionResult> DeleteCategoryAsync(int categoryId) {
            await _serviceManager.CategoryService.DeleteCategoryAsync(categoryId);
            return Ok(ApiResponseFactory.CreateResponse<object>(true, Messages.Success.EntityDeleted.Replace("{0}", "Category")));
        }

        [HttpGet("{parentCategoryId:int}/subcategories")]
        public async Task<IActionResult> GetSubCategoriesAsync(int parentCategoryId) {
            var subCategories = await _serviceManager.CategoryService.GetSubCategoriesAsync(parentCategoryId);
            return Ok(ApiResponseFactory.CreateResponse(true, Messages.Success.DataRetrieved, subCategories));
        }
    }
}
