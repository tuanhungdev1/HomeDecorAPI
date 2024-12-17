using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using HomeDecorAPI.Application.DTOs.AddressDtos;

namespace HomeDecorAPI.Presentation.Controllers {
    [Route("api/address")]
    [ApiController]
    [Authorize]
    public class AddressController : ControllerBase {
        private readonly IAddressService _addressService;
        private readonly IMapper _mapper;

        public AddressController(IAddressService addressService, IMapper mapper) {
            _addressService = addressService;
            _mapper = mapper;
        }

        private string GetCurrentUserId() {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }

        [HttpGet("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetAddressById(int id) {
            var userId = GetCurrentUserId();
            var address = await _addressService.GetAddressAsync(userId, id);

            if (address == null) {
                return NotFound(new ApiResponse<object> {
                    Success = false,
                    Message = "Address not found.",
                    Errors = new List<string> { "Address not found." },
                    StatusCode = 404
                });
            }

            return Ok(new ApiResponse<object> {
                Success = true,
                Message = "Address retrieved successfully.",
                Data = address,
                StatusCode = 200
            });
        }

        [HttpGet]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetAllAddresses() {
            var userId = GetCurrentUserId();
            var addresses = await _addressService.GetAllAddressesByUserIdAsync(userId);

            if (addresses == null || !addresses.Any()) {
                return NotFound(new ApiResponse<object> {
                    Success = false,
                    Message = "No addresses available.",
                    StatusCode = 404
                });
            }

            return Ok(new ApiResponse<object> {
                Success = true,
                Message = "Addresses retrieved successfully.",
                Data = addresses,
                StatusCode = 200
            });
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateAddress([FromBody] AddressForCreateDto addressForCreateDto) {
            var userId = GetCurrentUserId();
            
            await _addressService.CreateAddressAsync(userId, addressForCreateDto);
            return StatusCode(StatusCodes.Status201Created, new ApiResponse<object> {
                Success = true,
                Message = "Address created successfully.",
                StatusCode = 201
            });
        }

        [HttpPut("{id:int}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateAddress(int id, [FromBody] AddressForUpdateDto addressForUpdateDto) {
            var userId = GetCurrentUserId();
            await _addressService.UpdateAddressAsync(userId, id, addressForUpdateDto);
            return StatusCode(StatusCodes.Status200OK, new ApiResponse<object> {
                Success = true,
                Message = "Address updated successfully.",
                StatusCode = 200
            });
        }

        [HttpDelete("{id:int}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> DeleteAddress(int id) {
            var userId = GetCurrentUserId();
            await _addressService.DeleteAddressAsync(userId, id);
            return StatusCode(StatusCodes.Status200OK, new ApiResponse<object> {
                Success = true,
                Message = "Address deleted successfully.",
                StatusCode = 200
            });
        }

        [HttpPatch("{id:guid}/default")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> SetDefaultAddress(int id) {
            var userId = GetCurrentUserId();
            await _addressService.SetDefaultAddResAsync(userId, id);
            return Ok(new ApiResponse<object> {
                Success = true,
                Message = "Address set as default successfully.",
                StatusCode = 200
            });
        }
    }
}
