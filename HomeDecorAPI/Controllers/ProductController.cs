using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.ProductDtos;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.Constants;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using HomeDecorAPI.Application.Shared.Utilities;
using HomeDecorAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;


namespace HomeDecorAPI.Presentation.Controllers {

    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase {

        private readonly IServiceManager _serviceManager;

        public ProductController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllProductAsync([FromQuery] ProductRequestParameters productRequestParameters) {
            var (pagedList, metaData) = await _serviceManager.ProductService.GetAllProductsAsync(productRequestParameters.PageNumber, productRequestParameters.PageSize);

            Response.AddPaginationHeader(metaData);

            return Ok(ApiResponseFactory.CreateResponse(true, Messages.Success.DataRetrieved, pagedList));
        }

        [HttpGet("{productId:int}")]
        public async Task<IActionResult> GetProductById(int productId) {
            var productDto = await _serviceManager.ProductService.GetProductByIdAsync(productId);

            return Ok(ApiResponseFactory.CreateResponse(true, Messages.Success.DataRetrieved, productDto));
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateProductAsync([FromBody] ProductForCreateDto productForCreateDto) {
            var productDto = await _serviceManager.ProductService.CreateProductAsync(productForCreateDto);

            return StatusCode(StatusCodes.Status201Created, ApiResponseFactory.CreateResponse<object>(true, Messages.Success.EntityCreated.Replace("{0}", "Product")));
        }

        [HttpPut("{productId:int}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateProductAsync([FromBody] ProductForUpdateDto productForUpdateDto, int productId) {
            var productDto = await _serviceManager.ProductService.UpdateProductAsync(productId, productForUpdateDto);

            return Ok(ApiResponseFactory.CreateResponse(true, Messages.Success.EntityUpdated.Replace("{0}", "Product"), productDto));
        }


        [HttpDelete("{productId:int}")]
        public async Task<IActionResult> DeleteProductAsync(int productId) {
            await _serviceManager.ProductService.DeleteProductAsync(productId);

            return Ok(ApiResponseFactory.CreateResponse<object>(true, Messages.Success.EntityDeleted.Replace("{0}", "Product")));
        }
    }
}
