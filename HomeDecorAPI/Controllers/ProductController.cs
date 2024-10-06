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

        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            _productService = productService;
            _logger = logger;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllProductAsync([FromQuery] ProductRequestParameters productRequestParameters) {
            var (pagedList, metaData) = await _productService.GetAllProductsAsync(productRequestParameters.PageNumber, productRequestParameters.PageSize);

            Response.AddPaginationHeader(metaData);

            return Ok();
        }

        [HttpGet("{productId:int}")]
        public async Task<IActionResult> GetProductById(int productId) {
            var productDto = await _productService.GetProductByIdAsync(productId);

            return Ok();
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateProductAsync([FromBody] ProductForCreateDto productForCreateDto) {
            var productDto = await _productService.CreateProductAsync(productForCreateDto);

            return Created();
        }

        [HttpPut("{productId:int}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateProductAsync([FromBody] ProductForUpdateDto productForUpdateDto, int productId) {
            var productDto = await _productService.UpdateProductAsync(productId, productForUpdateDto);

            return Ok();
        }


        [HttpDelete("{productId:int}")]
        public async Task<IActionResult> DeleteProductAsync(int productId) {
            await _productService.DeleteProductAsync(productId);

            return Ok();
        }
    }
}
