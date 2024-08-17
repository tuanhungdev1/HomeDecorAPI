using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using HomeDecorAPI.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using HomeDecorAPI.Application.DTOs.AddressDtos;

namespace HomeDecorAPI.Presentation.Controllers
{
    [Route("api/address")]
    [ApiController]
    [Authorize]
    public class AddressController : ControllerBase {
        private readonly IServiceManager _service;
        private readonly IMapper _mapper;

        public AddressController(IServiceManager service, IMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        private string GetCurrentUserId() {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }

        [HttpGet("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetAddressById(Guid id) {
            var userId = GetCurrentUserId();
            var address = await _service.AddressService.GetAddressAsync(userId, id);

            if (address == null) {
                return NotFound(new ApiResponse<object>(
                    isSuccess: false,
                    message: "Address not found.",
                    errors: new List<string> { "The specified address could not be found." }
                ));
            }

            return Ok(new ApiResponse<AddressDto>(
                isSuccess: true,
                message: "Address retrieved successfully.",
                data: address
            ));
        }

        [HttpGet]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetAllAddresses() {
            var userId = GetCurrentUserId();
            var addresses = await _service.AddressService.GetAllAddressesByUserIdAsync(userId);

            if (addresses == null || !addresses.Any()) {
                return NotFound(new ApiResponse<object>(
                    isSuccess: false,
                    message: "No addresses found for the current user."
                ));
            }

            return Ok(new ApiResponse<IEnumerable<AddressDto>>(
                isSuccess: true,
                message: "Addresses retrieved successfully.",
                data: addresses
            ));
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateAddress([FromBody] AddressForCreateDto addressForCreateDto) {
            var userId = GetCurrentUserId();
            await _service.AddressService.CreateAddressAsync(userId, addressForCreateDto);
            return StatusCode(StatusCodes.Status201Created, new ApiResponse<AddressDto>(
                isSuccess: true,
                message: "Address created successfully."
            ));
        }

        [HttpPut("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateAddress(Guid id, [FromBody] AddressForUpdateDto addressForUpdateDto) {

            var userId = GetCurrentUserId();
            await _service.AddressService.UpdateAddressAsync(userId, id, addressForUpdateDto);
            return StatusCode(StatusCodes.Status200OK, new ApiResponse<AddressDto>(
                isSuccess: true,
                message: "Address updated successfully."
            ));
        }

        [HttpDelete("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> DeleteAddress(Guid id) {
            var userId = GetCurrentUserId();
            await _service.AddressService.DeleteAddressAsync( userId, id);
            return StatusCode(StatusCodes.Status200OK, new ApiResponse<AddressDto>(
                isSuccess: true,
                message: "Address deleted successfully."
            ));
        }

        [HttpPatch("{id:guid}/default")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> SetDefaultAddress(Guid id) {
            var userId = GetCurrentUserId();
            await _service.AddressService.SetDefaultAddResAsync(userId, id);
            return Ok(new ApiResponse<object>(
                isSuccess: true,
                message: "Default address set successfully."
            ));
        }
    }
}