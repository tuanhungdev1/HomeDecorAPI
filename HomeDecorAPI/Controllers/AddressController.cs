using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.Shared.ActionFilters;
using HomeDecorAPI.Application.Shared.ResponseFeatures;
using HomeDecorAPI.Application.Shared.Constants;
using HomeDecorAPI.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using HomeDecorAPI.Application.DTOs.AddressDtos;
using HomeDecorAPI.Application.Shared.Utilities;

namespace HomeDecorAPI.Presentation.Controllers {
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
        public async Task<IActionResult> GetAddressById(int id) {
            var userId = GetCurrentUserId();
            var address = await _service.AddressService.GetAddressAsync(userId, id);

            if (address == null) {
                return NotFound(ApiResponseFactory.CreateResponse<object>(
                    isSuccess: false,
                    message: Messages.Error.EntityNotFound("Address", id),
                    errors: new List<string> { Messages.Error.EntityNotFound("Address", id) }
                ));
            }

            return Ok(ApiResponseFactory.CreateResponse(true, Messages.Success.EntityAction("retrieved", "Address", id.ToString()), address));
        }

        [HttpGet]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetAllAddresses() {
            var userId = GetCurrentUserId();
            var addresses = await _service.AddressService.GetAllAddressesByUserIdAsync(userId);

            if (addresses == null || !addresses.Any()) {
                return NotFound(ApiResponseFactory.CreateResponse<object>(
                    isSuccess: false,
                    message: Messages.Info.NoDataAvailable
                ));
            }

            return Ok(ApiResponseFactory.CreateResponse(true, Messages.Success.DataRetrieved, addresses));
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateAddress([FromBody] AddressForCreateDto addressForCreateDto) {
            var userId = GetCurrentUserId();
            await _service.AddressService.CreateAddressAsync(userId, addressForCreateDto);
            return StatusCode(StatusCodes.Status201Created, ApiResponseFactory.CreateResponse<object>(true, Messages.Success.EntityCreated.Replace("{0}", "Address")));
        }

        [HttpPut("{id:int}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateAddress(int id, [FromBody] AddressForUpdateDto addressForUpdateDto) {
            var userId = GetCurrentUserId();
            await _service.AddressService.UpdateAddressAsync(userId, id, addressForUpdateDto);
            return StatusCode(StatusCodes.Status200OK, ApiResponseFactory.CreateResponse<object>(true, Messages.Success.EntityUpdated.Replace("{0}", "Address")));
        }

        [HttpDelete("{id:int}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> DeleteAddress(int id) {
            var userId = GetCurrentUserId();
            await _service.AddressService.DeleteAddressAsync(userId, id);
            return StatusCode(StatusCodes.Status200OK, ApiResponseFactory.CreateResponse<object>(true, Messages.Success.EntityDeleted.Replace("{0}", "Address")));
        }

        [HttpPatch("{id:guid}/default")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> SetDefaultAddress(int id) {
            var userId = GetCurrentUserId();
            await _service.AddressService.SetDefaultAddResAsync(userId, id);
            return Ok(ApiResponseFactory.CreateResponse<object>(true, Messages.Success.EntityAction("set as default", "Address", id.ToString())));
        }
    }
}
