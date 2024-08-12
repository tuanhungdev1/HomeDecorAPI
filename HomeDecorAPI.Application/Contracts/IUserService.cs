using HomeDecorAPI.Application.Shared.DTOs.AddressDtos;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos.HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts {
    public interface IUserService {
        Task<UserProfileDto> GetUserProfileAsync(string userId);
        Task<IdentityResult> UpdateUserProfileAsync(string userId, UserForUpdateProfileDto userForUpdateProfileDto);
        Task<IEnumerable<AddressDto>> GetAllUserAddressAsync(string userId);
        //Task CreateUserAddressAsync();
        //Task UpdateUserAddressAsync(string userId, string addressId);
        //Task DeleteUserAddRessAsync(string userId, string addressId);
    }
}
