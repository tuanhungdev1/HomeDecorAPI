using HomeDecorAPI.Application.DTOs.AddressDtos;


namespace HomeDecorAPI.Application.Contracts
{
    public interface IAddressService {
        Task<AddressDto> GetAddressAsync( string userId ,Guid id);
        Task<IEnumerable<AddressDto>> GetAllAddressesByUserIdAsync(string userId);
        Task CreateAddressAsync(string userId, AddressForCreateDto addressForCreateDto);
        Task UpdateAddressAsync(string userId, Guid id, AddressForUpdateDto addressForUpdateDto);
        Task DeleteAddressAsync(string userId, Guid id);
        Task SetDefaultAddResAsync(string userId, Guid addressId);
    }
}
