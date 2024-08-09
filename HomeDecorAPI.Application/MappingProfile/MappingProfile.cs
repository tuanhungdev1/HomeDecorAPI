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

namespace HomeDecorAPI.Application.MappingProfile {
    public class MappingProfile : Profile {
        public MappingProfile() {
            // USER
            CreateMap<UserForRegistrationDto, User>();


            // USER

        }
    }
}
