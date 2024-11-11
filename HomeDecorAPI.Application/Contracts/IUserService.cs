using HomeDecorAPI.Application.DTOs.AddressDtos;
using HomeDecorAPI.Application.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos.HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.RequestFeatures;
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
        Task<(IEnumerable<UserDto> userDtos, MetaData metaData)> GetAllUserAsync(UserRequestParameters userRequestParameters);
        Task<UserDto> GetUserInfoAsync(string userId);
        Task<UserDto> UpdateUserInforAsync(string userId, UserForUpdateDto userForUpdateDto);
        Task<UserDto> CreateUserAsync(UserForCreateDto userForCreateDto);
        Task DeleteUserAsync(string userId);
    }
}
