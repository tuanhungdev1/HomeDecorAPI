using AutoMapper;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos.HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using HomeDecorAPI.Application.Shared.DTOs.AddressDtos;

namespace HomeDecorAPI.Application.MappingProfile {
    public class MappingProfile : Profile {
        public MappingProfile() {
            // USER
            CreateMap<UserForRegistrationDto, User>();
            CreateMap<User, UserDto>();
            CreateMap<UserForLoginDto, User>();
            CreateMap<User, UserProfileDto>();
            CreateMap<User, UserForUpdateProfileDto>();

            //Address
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<AddressForUpdateDto, Address>().ForMember(dest => dest.Id, opt => opt.Ignore()); 
            CreateMap<AddressForCreateDto, Address>();
        }
    }
}
