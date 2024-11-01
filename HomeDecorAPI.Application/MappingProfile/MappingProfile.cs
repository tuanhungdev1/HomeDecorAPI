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
using HomeDecorAPI.Application.DTOs.SupplierDtos;
using HomeDecorAPI.Application.DTOs.BrandDtos;

namespace HomeDecorAPI.Application.MappingProfile
{
    public class MappingProfile : Profile {
        public MappingProfile() {
            // USER
            CreateMap<UserForRegistrationDto, User>().ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.ProfilePicture, opt => opt.MapFrom(src => src.UserImage != null ? src.UserImage.Url : null));
            CreateMap<UserForUpdateProfileDto, User>().ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<UserForLoginDto, User>().ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<User, UserProfileDto>()
                .ForMember(dest => dest.ProfilePicture, opt => opt.MapFrom(src => src.UserImage != null ? src.UserImage.Url : null));
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
            CreateMap<Category, CategoryDto>()
                .ForMember(dest => dest.SubCategories, opt => opt.MapFrom(src => src.SubCategories));
            CreateMap<CategoryForCreateDto, Category>()
                .ForMember(dest => dest.Id, act => act.Ignore());
            CreateMap<CategoryForCreateDto, CategoryDto>();
            CreateMap<CategoryForUpdateDto, Category>()

                .ForMember(dest => dest.Id, act => act.Ignore());
            // CATEGORY

            // CART
            CreateMap<Cart, CartDto>();
            // CART

            // SUPPLIER
            CreateMap<Supplier, SupplierDto>();
            CreateMap<SupplierForCreateDto, Supplier>()
                .ForMember(dest => dest.Id, act => act.Ignore());
            CreateMap<SupplierForUpdateDto, Supplier>()
                .ForMember(dest => dest.Id, act => act.Ignore());
            // SUPPLIER

            // BRAND
            CreateMap<Brand, BrandDto>();
                
            CreateMap<BrandForCreateDto, Brand>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<BrandForUpdateDto, Brand>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
            // BRAND
        }
    }
}
