using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.Shared.DTOs.AddressDtos;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos.HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Services {
    public class UserService : IUserService {
        private readonly UserManager<User> _userService;
        private readonly IMapper _mapper;

        public UserService(UserManager<User> userManager, IMapper mapper)
        {
            _userService = userManager;
            _mapper = mapper;
        }

        public async Task<UserProfileDto> GetUserProfileAsync(string userId) {
            var user = await _userService.FindByIdAsync(userId);

            if (user == null) {
                throw new UserNotFoundException($"UserId {userId} not found in the system.");
            }

            return _mapper.Map<UserProfileDto>(user);
        }

        public async Task<IdentityResult> UpdateUserProfileAsync(string userId, UserForUpdateProfileDto userForUpdateProfileDto) {
            var user = await _userService.FindByIdAsync(userId);
            if (user == null) {
                throw new UserNotFoundException($"UserId {userId} not found in the system.");
            }
            var result = await _userService.UpdateAsync(_mapper.Map(userForUpdateProfileDto, user));

            return result;
        }

        public async Task<IEnumerable<AddressDto>> GetAllUserAddressAsync(string userId) {
            var user = await _userService.FindByIdAsync(userId);

            if (user == null) {
                throw new UserNotFoundException($"UserId {userId} not found in the system.");
            }

            var addressList = user.Addresses;

            return _mapper.Map<IEnumerable<AddressDto>>(addressList);
        }
    }
}
