using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.SupplierDtos;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HomeDecorAPI.Presentation.Controllers
{
    [ApiController]
    [Route("/api/supplier")]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplierService;
        private readonly ILoggerService _loggerService;
        public SupplierController(ILoggerService loggerService,
                                  ISupplierService supplierService
        )
        {
            _loggerService = loggerService;
            _supplierService = supplierService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllSupplier()
        {
            var supplierDtos = await _supplierService.GetAllSupplierAsync();
            _loggerService.LogInfo("Lấy danh sách Supplier thành công.");
            return Ok(new ApiResponse<IEnumerable<SupplierDto>>
            {
                Success = true,
                Message = "Lấy tất cả dữ liệu Supplier thành công",
                Data = supplierDtos,
                StatusCode = 200
            });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSupplierById(int id)
        {
            var supplierDto = await _supplierService.GetSupplierByIdAsync(id);
            _loggerService.LogInfo($"Lấy dữ liệu Supplier với ID:{id} thành công.");
            return Ok(new ApiResponse<SupplierDto>
            {
                Success = true,
                Message = $"Lấy dữ liệu Supplier với ID:{id} thành công",
                Data = supplierDto,
                StatusCode = 200
            });
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateSupplier([FromBody] SupplierForCreateDto supplierForCreateDto)
        {
            var supplierDto = await _supplierService.CreateSupplierAsync(supplierForCreateDto);
            _loggerService.LogInfo("Tạo một Supplier mới thành công.");

            return StatusCode(201, new ApiResponse<SupplierDto>
            {
                Success = true,
                Message = "Tạo thành công một Supplier mới.",
                Data = supplierDto,
                StatusCode = 201
            });
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateSupplier(int id,[FromBody] SupplierForUpdateDto supplierForUpdateDto)
        {
            var supplierDto = await _supplierService.UpdateSupplierAsync(id ,supplierForUpdateDto);
            _loggerService.LogInfo($"Cập nhật một Supplier với ID: {id} thành công.");

            return StatusCode(200, new ApiResponse<SupplierDto>
            {
                Success = true,
                Message = $"Cập nhật thành công Supplier với ID:{id}.",
                Data = supplierDto,
                StatusCode = 200
            });
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
 
        public async Task<IActionResult> DeleteSupplier(int id)
        {
            await _supplierService.DeleteSupplierAsync(id);
            _loggerService.LogInfo($"Xóa một Supplier với ID: {id} thành công.");

            return StatusCode(200, new ApiResponse<SupplierDto>
            {
                Success = true,
                Message = $"Xóa thành công Supplier với ID:{id}.",
                StatusCode = 200
            });
        }
    }
}
