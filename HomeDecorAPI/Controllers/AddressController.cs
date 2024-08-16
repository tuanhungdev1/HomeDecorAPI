using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.DTOs.AddressDtos;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using HomeDecorAPI.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDecorAPI.Presentation.Controllers {
    [Route("api/user/{userId}/address")]
    [ApiController]
    [Authorize]
    public class AddressController : ControllerBase {
        private readonly IServiceManager _service;
        private readonly IMapper _mapper;

        public AddressController(IServiceManager service, IMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/user/{userId}/address/{id}
        [HttpGet("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetAddressById(string userId, Guid id) {
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

        // GET: api/user/{userId}/address
        [HttpGet]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetAllAddressesByUserId(string userId) {
            var addresses = await _service.AddressService.GetAllAddressesByUserIdAsync(userId);

            if (addresses == null || !addresses.Any()) {
                return NotFound(new ApiResponse<object>(
                    isSuccess: false,
                    message: "No addresses found for the specified user."
                ));
            }

            return Ok(new ApiResponse<IEnumerable<AddressDto>>(
                isSuccess: true,
                message: "Addresses retrieved successfully.",
                data: addresses
            ));
        }

        // POST: api/user/{userId}/address
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateAddress(string userId, [FromBody] AddressForCreateDto addressForCreateDto) {

            await _service.AddressService.CreateAddressAsync(userId, address);

            var createdAddressDto = _mapper.Map<AddressDto>(address);

            return CreatedAtAction(nameof(GetAddressById), new { userId, id = createdAddressDto.Id }, new ApiResponse<AddressDto>(
                isSuccess: true,
                message: "Address created successfully.",
                data: createdAddressDto
            ));
        }

        // PUT: api/user/{userId}/address/{id}
        [HttpPut("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateAddress(string userId, Guid id, [FromBody] AddressForUpdateDto addressForUpdateDto) {
            if (!ModelState.IsValid) {
                return BadRequest(new ApiResponse<object>(
                    isSuccess: false,
                    message: "Invalid data.",
                    errors: ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList()
                ));
            }

            var address = await _service.AddressService.GetAddressAsync(userId, id);
            if (address == null) {
                return NotFound(new ApiResponse<object>(
                    isSuccess: false,
                    message: "Address not found."
                ));
            }

            _mapper.Map(addressForUpdateDto, address);
            await _service.AddressService.UpdateAddressAsync(address);

            return NoContent();
        }

        // DELETE: api/user/{userId}/address/{id}
        [HttpDelete("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> DeleteAddress(string userId, Guid id) {
            var address = await _service.AddressService.GetAddressAsync(userId, id);
            if (address == null) {
                return NotFound(new ApiResponse<object>(
                    isSuccess: false,
                    message: "Address not found."
                ));
            }

            await _service.AddressService.DeleteAddressAsync(address);

            return NoContent();
        }

        // PATCH: api/user/{userId}/address/{id}/default
        [HttpPatch("{id:guid}/default")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> SetDefaultAddress(string userId, Guid id) {
            var result = await _service.AddressService.SetDefaultAddressAsync(userId, id);

            if (!result.Succeeded) {
                var errors = result.Errors.Select(e => e.Description).ToList();

                return BadRequest(new ApiResponse<object>(
                    isSuccess: false,
                    message: "Failed to set default address.",
                    errors: errors
                ));
            }

            return Ok(new ApiResponse<object>(
                isSuccess: true,
                message: "Default address set successfully."
            ));
        }
    }
}
