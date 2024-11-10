using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.ProductDtos;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.Constants;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using HomeDecorAPI.Application.Shared.Utilities;
using HomeDecorAPI.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;


namespace HomeDecorAPI.Presentation.Controllers {

    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase {

        private readonly IProductService _productService;
        private readonly ILoggerService _logger;

        public ProductController(IProductService productService, ILoggerService logger)
        {
            _productService = productService;
            _logger = logger;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllProductAsync([FromQuery] ProductRequestParameters productRequestParameters) {
            var (pagedList, metaData) = await _productService.GetAllProductsAsync(productRequestParameters.PageNumber, productRequestParameters.PageSize);

            Response.AddPaginationHeader(metaData);
            _logger.LogInfo("Lấy dữ liệu danh sách sản phẩm thành công.");
            return Ok(new ApiResponse<IEnumerable<ProductDto>>
            {
                Success = true,
                StatusCode = 200,
                Data = pagedList,
                Message = "Lấy dữ liệu danh sách sản phẩm thành công."
            });
        }

        [HttpGet("{productId:int}")]
        public async Task<IActionResult> GetProductById(int productId) {
            var productDto = await _productService.GetProductByIdAsync(productId);

            _logger.LogInfo($"Lấy dữ liệu sản phẩm với ID: {productId} thành công.");
            return Ok(new ApiResponse<ProductDto>
            {
                Success = true,
                StatusCode = 200,
                Data = productDto,
                Message = $"Lấy dữ liệu sản phẩm với ID: {productId} thành công."
            });
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateProductAsync([FromForm] ProductForCreateDto productForCreateDto) {
            var productDto = await _productService.CreateProductAsync(productForCreateDto);
            _logger.LogInfo($"Tạo thành công một sản phẩm mới với PRODUCT_ID: {productDto.Id}");
            return StatusCode(StatusCodes.Status201Created, new ApiResponse<string>
            {
                StatusCode = 201,
                Success = true,
                Message = "Chúc mừng bạn đã tạo thành công một sản phẩm mới."
            });
        }

        [HttpPut("{productId:int}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateProductAsync([FromBody] ProductForUpdateDto productForUpdateDto, int productId) {
            var productDto = await _productService.UpdateProductAsync(productId, productForUpdateDto);

            _logger.LogInfo($"Cập nhật dữ liệu sản phẩm với ID: {productId} thành công.");
            return Ok(new ApiResponse<ProductDto>
            {
                Success = true,
                StatusCode = 200,
                Data = productDto,
                Message = $"Cập nhật dữ liệu sản phẩm với ID: {productId} thành công."
            });
        }


        [HttpDelete("{productId:int}")]
        public async Task<IActionResult> DeleteProductAsync(int productId) {
            await _productService.DeleteProductAsync(productId);
            _logger.LogInfo($"Xóa dữ liệu sản phẩm với ID: {productId} thành công.");
            return Ok(new ApiResponse<ProductDto>
            {
                Success = true,
                StatusCode = 200,
                Message = $"Xóa dữ liệu sản phẩm với ID: {productId} thành công."
            });
        }
    }
}
