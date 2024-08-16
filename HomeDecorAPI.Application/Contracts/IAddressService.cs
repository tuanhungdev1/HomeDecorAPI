using HomeDecorAPI.Application.Shared.DTOs.AddressDtos;
using HomeDecorAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts {
    public interface IAddressService {
        Task<AddressDto> GetAddressAsync( string userId ,Guid id);
        Task<IEnumerable<AddressDto>> GetAllAddressesByUserIdAsync(string userId);
        Task CreateAddressAsync(AddressForCreateDto addressForCreateDto);
        Task UpdateAddressAsync(AddressForUpdateDto addressForUpdateDto);
        Task DeleteAddressAsync(Guid id);
        Task SetDefaultAddResAsync(string userId, Guid addressId);
    }
}
