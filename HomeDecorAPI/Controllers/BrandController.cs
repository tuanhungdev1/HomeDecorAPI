using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.BrandDtos;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using HomeDecorAPI.Application.Shared.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HomeDecorAPI.Presentation.Controllers
{
    [ApiController]
    [Route("/api/brand")]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;
        private readonly ILoggerService _logger;
        public BrandController(IBrandService brandService, ILoggerService logger)
        {
            _brandService = brandService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBrand([FromQuery] BrandRequestParameters brandRequestParameters)
        {
            var pagedResult = await _brandService.GetAllBrandAsync(brandRequestParameters);
            _logger.LogInfo("Lấy dữ liệu tất cả Brand thành công.");
            Response.AddPaginationHeader(pagedResult.metaData);
            return Ok(new ApiResponse<IEnumerable<BrandDto>>
            {
                Success = true,
                Data = pagedResult.brands,
                Message = "Lấy dữ liệu tất cả Brand thành công.",
                StatusCode = 200
            });
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrandById(int id)
        {
            var brandDto = await _brandService.GetBrandByIdAsync(id);

            _logger.LogInfo("Lấy dữ liệu Brand thành công.");
            return Ok(new ApiResponse<BrandDto>
            {
                Success = true,
                Data = brandDto,
                Message = "Lấy dữ liệu Brand thành công.",
                StatusCode = 200
            });
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateBrand([FromBody] BrandForCreateDto brandForUpdateDto)
        {
            var brandDto = await _brandService.CreateBrandAsync(brandForUpdateDto);

            _logger.LogInfo("Tạo một Brand mới thành công.");
            return Ok(new ApiResponse<object>
            {
                Success = true,
                Message = "Tạo Brand mới thành công.",
                StatusCode = 200,
            });
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateBrand(int id, [FromBody] BrandForUpdateDto brandForUpdateDto)
        {
            var brandDto = await _brandService.UpdateBrandAsync(id, brandForUpdateDto);

            _logger.LogError("Cập nhật một Brand mới thành công.");
            return Ok(new ApiResponse<object>
            {
                Success = true,
                Message = "Cập nhật Brand mới thành công.",
                StatusCode = 200,
            });
        }


        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            await _brandService.DeleteBrandAsync(id);

            _logger.LogError("Xóa một Brand mới thành công.");
            return Ok(new ApiResponse<object>
            {
                Success = true,
                Message = "Xóa Brand mới thành công.",
                StatusCode = 200,
            });
        }
    }
}
