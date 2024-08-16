﻿using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Shared.DTOs.AddressDtos;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Services {
    public class AddressService : IAddressService {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public AddressService(IRepositoryManager repositoryManager, IMapper mapper, UserManager<User> userManager) {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<AddressDto> GetAddressAsync(string userId, Guid id) {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) 
                throw new UserNotFoundException($"Could not find user with ID: {userId}");
            var address = await _repositoryManager.AddressRepository.GetByIdAsync(id);

            if (address == null) {
                throw new AddressForUserNotFound($"Could not find address with ID: {id}");
            }

            return _mapper.Map<AddressDto>(address);
        }

        public async Task<IEnumerable<AddressDto>> GetAllAddressesByUserIdAsync(string userId) {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
                throw new UserNotFoundException($"User with ID '{userId}' not found.");

            return _mapper.Map<IEnumerable<AddressDto>>(user.Addresses);
        }

        public async Task CreateAddressAsync(AddressForCreateDto addressForCreateDto) {
            var address = _mapper.Map<Address>(addressForCreateDto);

            if (address == null) {
                throw new Exception("Failed to map the address DTO to the address entity.");
            }

            await _repositoryManager.AddressRepository.AddAsync(address);
        }

        public async Task UpdateAddressAsync(AddressForUpdateDto addressForUpdateDto) {
            var address = _mapper.Map<Address>(addressForUpdateDto);

            if (address == null) {
                throw new Exception("Failed to map the address DTO to the address entity.");
            }

            await _repositoryManager.AddressRepository.UpdateAsync(address);
        }

        public async Task DeleteAddressAsync(Guid id) {
            var address = await _repositoryManager.AddressRepository.GetByIdAsync(id);

            if (address == null) {
                throw new AddressForUserNotFound($"Could not find address with ID '{id}' to delete.");
            }

            await _repositoryManager.AddressRepository.RemoveAsync(address);
        }

        public async Task SetDefaultAddResAsync(string userId, Guid addressId) {
            var user = await _userManager.FindByIdAsync(userId)
                ?? throw new UserNotFoundException($"User with ID '{userId}' not found.");

            // Tìm địa chỉ theo ID
            var addressToSetDefault = user.Addresses.FirstOrDefault(a => a.Id == addressId)
                        ?? throw new AddressForUserNotFound($"Address with ID '{addressId}' not found for the user.");

            // Nếu địa chỉ đã là mặc định, không cần làm gì thêm
            if (addressToSetDefault.IsDefault) return;

            // Tìm địa chỉ hiện tại đang là mặc định và đặt nó thành không mặc định
            var currentDefaultAddress = user.Addresses.FirstOrDefault(a => a.IsDefault);
            if (currentDefaultAddress != null) {
                currentDefaultAddress.IsDefault = false;
            }

            // Đặt địa chỉ mới là mặc định
            addressToSetDefault.IsDefault = true;

            // Cập nhật cơ sở dữ liệu
            await _repositoryManager.SaveAsync();
        }
    }
}
