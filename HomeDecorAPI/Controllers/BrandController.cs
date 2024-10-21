using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.BrandDtos;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.BadRequestException;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
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
        public async Task<IActionResult> GetAllBrand()
        {
            try
            {
                var brands = await _brandService.GetAllBrandAsync();
                _logger.LogInfo("Lấy dữ liệu tất cả Brand thành công.");
                return Ok(new ApiResponse<IEnumerable<BrandDto>>
                {
                    Success = true,
                    Data = brands,
                    Message = "Lấy dữ liệu tất cả Brand thành công.",
                    StatusCode = 200
                });
            }
            catch (Exception ex)
            {
                _logger.LogError("Có lỗi không thể lấy tất cả Brand.");
                return StatusCode(500, new ApiResponse<object>
                {
                    Success = false,
                    Message = "Có lỗi xảy ra. Vui lòng thử lại.",
                    StatusCode = 500,
                    Errors = new List<string> { ex.Message }
                });
            }
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrandById(int id)
        {
            try
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
            catch (BrandNotFoundException ex) {
                _logger.LogError($"Không tồn tại Brand: {id} trong hệ thống.");
                return BadRequest(new ApiResponse<object>
                {
                    Success = false,
                    Message = $"Không tồn tại Brand với ID: {id}",
                    StatusCode = 400,
                    Errors = new List<string> { ex.Message }
                });
            }
            catch (Exception ex)
            {
                _logger.LogError("Có lỗi không thể lấy dữ liệu Brand.");
                return StatusCode(500, new ApiResponse<object>
                {
                    Success = false,
                    Message = "Có lỗi xảy ra. Vui lòng thử lại.",
                    StatusCode = 500,
                    Errors = new List<string> { ex.Message }
                });
            }
        }

        [Authorize("Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateBrand([FromBody] BrandForCreateDto brandForUpdateDto)
        {
            try
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
            catch(FileUploadBadRequestException ex)
            {
                _logger.LogError("Hình ảnh upload không hợp lệ.");
                return BadRequest(new ApiResponse<object>
                {
                    Success = false,
                    Message = "Hình ảnh không hợp lệ.",
                    StatusCode = 400,
                    Errors = new List<string> { ex.Message }
                });
            }
            catch(Exception ex)
            {
                _logger.LogError("Có lỗi không thể tạo Brand mới.");
                return StatusCode(500, new ApiResponse<object>
                {
                    Success = false,
                    Message = "Có lỗi xảy ra. Vui lòng thử lại.",
                    StatusCode = 500,
                    Errors = new List<string> { ex.Message }
                });
            }
        }

        [Authorize("Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBrand(int id, [FromBody] BrandForUpdateDto brandForUpdateDto)
        {
            try
            {
                var brandDto = await _brandService.UpdateBrandAsync(id ,brandForUpdateDto);

                _logger.LogError("Cập nhật một Brand mới thành công.");
                return Ok(new ApiResponse<object>
                {
                    Success = true,
                    Message = "Cập nhật Brand mới thành công.",
                    StatusCode = 200,
                });
            }
            catch (FileUploadBadRequestException ex)
            {
                _logger.LogError("Hình ảnh upload không hợp lệ.");
                return BadRequest(new ApiResponse<object>
                {
                    Success = false,
                    Message = "Hình ảnh không hợp lệ.",
                    StatusCode = 400,
                    Errors = new List<string> { ex.Message }
                });
            }
            catch (Exception ex)
            {
                _logger.LogError("Có lỗi không thể tạo Brand mới.");
                return StatusCode(500, new ApiResponse<object>
                {
                    Success = false,
                    Message = "Có lỗi xảy ra. Vui lòng thử lại.",
                    StatusCode = 500,
                    Errors = new List<string> { ex.Message }
                });
            }
        }


        [Authorize("Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            try
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
            catch (BrandNotFoundException ex)
            {
                _logger.LogError($"Không tồn tại Brand: {id} trong hệ thống.");
                return BadRequest(new ApiResponse<object>
                {
                    Success = false,
                    Message = $"Không tồn tại Brand với ID: {id}",
                    StatusCode = 400,
                    Errors = new List<string> { ex.Message }
                });
            }
            catch (Exception ex)
            {
                _logger.LogError("Có lỗi không thể tạo Brand mới.");
                return StatusCode(500, new ApiResponse<object>
                {
                    Success = false,
                    Message = "Có lỗi xảy ra. Vui lòng thử lại.",
                    StatusCode = 500,
                    Errors = new List<string> { ex.Message }
                });
            }
        }
    }
}
