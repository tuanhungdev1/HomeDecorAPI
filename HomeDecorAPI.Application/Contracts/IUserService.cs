﻿using HomeDecorAPI.Application.DTOs.AddressDtos;
using HomeDecorAPI.Application.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos.HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts
{
    public interface IUserService {
        Task<UserDto> GetUserProfileAsync(string userId);
        Task UpdateUserProfileAsync(string userId, UserForUpdateProfileDto userForUpdateProfileDto);
        Task<IEnumerable<AddressDto>> GetAllUserAddressAsync(string userId);
    }
}
