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
using HomeDecorAPI.Application.DTOs.WishlistDtos;

namespace HomeDecorAPI.Application.MappingProfile
{
    public class MappingProfile : Profile {
        public MappingProfile() {
            // USER
            CreateMap<User, UserDto>();
            CreateMap<UserForRegistrationDto, User>().ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<UserForUpdateDto, User>().ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<UserForCreateDto, User>();
            CreateMap<UserForLoginDto, User>().ForMember(dest => dest.Id, opt => opt.Ignore());
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

            CreateMap<ProductVariant, ProductVariantDto>()
                .ForMember(dest => dest.ProductName, act => act.MapFrom(p => p.Product.Name));
            CreateMap<ProductVariantForCreateDto, ProductVariant>();
            CreateMap<ProductVariantForUpdateDto, ProductVariant>();

            CreateMap<ProductDetails, ProductDetailsDto>();
            CreateMap<ProductDetailsForCreateDto, ProductDetails>();
            CreateMap<ProductDetailsForUpdateDto, ProductDetails>();

            CreateMap<ProductImage, ProductImageDto>();
            CreateMap<ProductImageForCreateDto, ProductImage>();
            CreateMap<ProductImageForUpdateDto, ProductImage>();
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

            // WISHLISTITEM
            CreateMap<WishlistItem, WishlistItemDto>();
            // WISHLISTITEM
        }
    }
}
