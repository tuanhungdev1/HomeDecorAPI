using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HomeDecorAPI.Application.DTOs.BrandDtos;
using HomeDecorAPI.Domain.Entities;

namespace HomeDecorAPI.Application.MappingProfile
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<Brand, BrandDto>();
            CreateMap<BrandForCreateDto, Brand>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<BrandForUpdateDto, Brand>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
