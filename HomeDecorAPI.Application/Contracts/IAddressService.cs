using HomeDecorAPI.Application.DTOs.AddressDtos;


namespace HomeDecorAPI.Application.Contracts
{
    public interface IAddressService {
        Task<AddressDto> GetAddressAsync( string userId ,int id);
        Task<IEnumerable<AddressDto>> GetAllAddressesByUserIdAsync(string userId);
        Task CreateAddressAsync(string userId, AddressForCreateDto addressForCreateDto);
        Task UpdateAddressAsync(string userId, int id, AddressForUpdateDto addressForUpdateDto);
        Task DeleteAddressAsync(string userId, int id);
        Task SetDefaultAddResAsync(string userId, int addressId);
    }
}
