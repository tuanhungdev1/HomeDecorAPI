using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Application.Shared.DTOs.UserDtos.HomeDecorAPI.Application.Shared.DTOs.UserDtos;
using HomeDecorAPI.Application.DTOs.AddressDtos;
using HomeDecorAPI.Application.DTOs.UserDtos;
using HomeDecorAPI.Application.DTOs.ProductDtos;
using HomeDecorAPI.Application.DTOs.CategoryDto;
using HomeDecorAPI.Application.DTOs.CategoryDtos;
using HomeDecorAPI.Application.DTOs.CartDtos;

namespace HomeDecorAPI.Application.MappingProfile
{
    public class MappingProfile : Profile {
        public MappingProfile() {
            // USER
            CreateMap<UserForRegistrationDto, User>();
            CreateMap<User, UserDto>();
            CreateMap<UserForLoginDto, User>();
            CreateMap<User, UserProfileDto>();
            CreateMap<User, UserForUpdateProfileDto>();
            // USER

            // Address
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<AddressForUpdateDto, Address>().ForMember(dest => dest.Id, opt => opt.Ignore()); 
            CreateMap<AddressForCreateDto, Address>();
            // Address

            // PRODUCT
            CreateMap<Product, ProductDto>();
            CreateMap<ProductForCreateDto,  Product>()
                .ForMember(dest => dest.Id, act => act.Ignore());
            CreateMap<ProductForCreateDto, ProductDto>();
                
            CreateMap<ProductForUpdateDto, Product>()
                .ForMember(dest => dest.Id, act => act.Ignore());
            // PRODUCT

            // CATEGORY
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryForCreateDto, Category>()
                .ForMember(dest => dest.Id, act => act.Ignore());
            CreateMap<CategoryForCreateDto, CategoryDto>();
            CreateMap<CategoryForUpdateDto, Category>()
                .ForMember(dest => dest.Id, act => act.Ignore());
            // CATEGORY

            // CART
            CreateMap<Cart, CartDto>();
            // CART
        }
    }
}
