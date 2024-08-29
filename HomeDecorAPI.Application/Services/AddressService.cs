using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.AddressDtos;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Services
{
    //public class AddressService : IAddressService {
    //    private readonly IRepositoryManager _repositoryManager;
    //    private readonly IMapper _mapper;
    //    private readonly UserManager<User> _userManager;

    //    public AddressService(IRepositoryManager repositoryManager, IMapper mapper, UserManager<User> userManager) {
    //        _repositoryManager = repositoryManager;
    //        _mapper = mapper;
    //        _userManager = userManager;
    //    }

    //    private async Task<User> IsUserExisting(string userId) {
    //        var user = await _userManager.FindByIdAsync(userId);
    //        if (user == null)
    //            throw new UserNotFoundException($"Could not find user with ID: {userId}");

    //        return user;
    //    }

    //    public async Task<AddressDto> GetAddressAsync(string userId, Guid id) {
    //        var user = await IsUserExisting(userId);
    //        var address = user.Addresses.Where(a => a.Id == id).FirstOrDefault();
    //        if (address == null) {
    //            throw new AddressForUserNotFound($"Could not find address with ID: {id}");
    //        }
    //        return _mapper.Map<AddressDto>(address);
    //    }

    //    public async Task<IEnumerable<AddressDto>> GetAllAddressesByUserIdAsync(string userId) {
    //        var user = await IsUserExisting(userId);
    //        return _mapper.Map<IEnumerable<AddressDto>>(user.Addresses);
    //    }

    //    public async Task CreateAddressAsync(string userId, AddressForCreateDto addressForCreateDto) {
    //        var user = await IsUserExisting(userId);
    //        var address = _mapper.Map<Address>(addressForCreateDto);

    //        if (address == null) {
    //            throw new Exception("Failed to map the address DTO to the address entity.");
    //        }
    //        user.Addresses.Add(address);
    //        await _repositoryManager.SaveAsync();
    //    }

    //    public async Task UpdateAddressAsync(string userId, Guid id, AddressForUpdateDto addressForUpdateDto) {
    //        var user = await IsUserExisting(userId);
    //        var address = _mapper.Map<Address>(addressForUpdateDto);

    //        if (address == null) {
    //            throw new Exception("Failed to map the address DTO to the address entity.");
    //        }
    //        var addressUpdate = user.Addresses.FirstOrDefault(a => a.Id == id);
    //        if (addressUpdate == null) {
    //            throw new AddressForUserNotFound("Address not found.");
    //        }

    //        Cập nhật địa chỉ với thông tin từ DTO
    //        _mapper.Map(addressForUpdateDto, addressUpdate);
    //        await _repositoryManager.SaveAsync();
    //    }

    //    public async Task DeleteAddressAsync(string userId, Guid id) {
    //        var user = await IsUserExisting(userId);
    //        var address = user.Addresses.FirstOrDefault(a => a.Id == id);

    //        if (address == null) {
    //            throw new AddressForUserNotFound($"Could not find address with ID '{id}' to delete.");
    //        }
    //        user.Addresses.Remove(address);
    //        await _repositoryManager.SaveAsync();
    //    }

    //    public async Task SetDefaultAddResAsync(string userId, Guid addressId) {
    //        var user = await IsUserExisting(userId);

    //        Tìm địa chỉ theo ID
    //       var addressToSetDefault = user.Addresses.FirstOrDefault(a => a.Id == addressId)
    //                   ?? throw new AddressForUserNotFound($"Address with ID '{addressId}' not found for the user.");

    //        Nếu địa chỉ đã là mặc định, không cần làm gì thêm
    //        if (addressToSetDefault.IsDefault) return;

    //        Tìm địa chỉ hiện tại đang là mặc định và đặt nó thành không mặc định
    //        var currentDefaultAddress = user.Addresses.FirstOrDefault(a => a.IsDefault);
    //        if (currentDefaultAddress != null) {
    //            currentDefaultAddress.IsDefault = false;
    //        }

    //        Đặt địa chỉ mới là mặc định
    //        addressToSetDefault.IsDefault = true;

    //        Cập nhật cơ sở dữ liệu
    //        await _repositoryManager.SaveAsync();
    //    }
    //}
}
