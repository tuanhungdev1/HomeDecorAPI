using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.ProductDtos;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Shared.Constants;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using HomeDecorAPI.Application.Shared.Utilities;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.BadRequestException;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Services {
    public class ProductService : IProductService {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICloudinaryService _cloudinaryService;
        private readonly ILoggerService _logger;

        public ProductService(IProductRepository productRepository, IMapper mapper, IUnitOfWork unitOfWork, ICloudinaryService cloudinaryService, ILoggerService loggerService)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _cloudinaryService = cloudinaryService;
            _logger = loggerService;
        }

        public async Task<(IEnumerable<ProductDto>, MetaData)> GetAllProductsAsync(int pageNumber, int pageSize) {
            var products = await _productRepository.GetAllAsync(false);
            var productDtoList = _mapper.Map<IEnumerable<ProductDto>>(products);
            var pagedResult = PagedList<ProductDto>.ToPagedList(productDtoList, pageNumber, pageSize);
            return (pagedResult, pagedResult.MetaData);
        }

        public async Task<ProductDto> GetProductByIdAsync(int productId) {
            var product = await _productRepository.FindByCondition(p => p.Id == productId, false)
                                                    .Include(p => p.ProductVariants)
                                                        .ThenInclude(pv => pv.Images)
                                                    .Include(p => p.ProductDetails)
                                                    .SingleOrDefaultAsync()
                                                    ;

            if (product == null) {
                _logger.LogError($"Không tìm thấy Product với ID: {productId}");
                throw new ProductNotFoundException($"{productId}");
            }
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> CreateProductAsync(ProductForCreateDto productForCreateDto)
        {
            await ValidateProductData(productForCreateDto);

            try
            {
                await _unitOfWork.BeginTransactionAsync();

                var product = _mapper.Map<Product>(productForCreateDto);
                await _productRepository.AddAsync(product);
                await _productRepository.SaveChangesAsync();
               
                var productDetails = _mapper.Map<ProductDetails>(productForCreateDto.Details);
                product.ProductDetails = productDetails;
                _productRepository.Update(product);

                var productVariants = await ProcessProductVariants(productForCreateDto.Variants, product.Id);
                product.ProductVariants = productVariants;

                _productRepository.Update(product);
                await _unitOfWork.CommitAsync();

                return _mapper.Map<ProductDto>(product);
            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                _logger.LogError($"Error creating product: {ex.Message}");
                throw new ProductBadRequestException("Failed to create product. Please try again.");
            }
        }
        private async Task ValidateProductData(ProductForCreateDto productForCreateDto)
        {
            if(productForCreateDto.Variants == null || !productForCreateDto.Variants.Any())
            {
                throw new ProductBadRequestException("Sản phẩm cần ít nhất 1 loại sản phẩm theo màu sắc.");
            } 

            foreach(var variant in productForCreateDto.Variants)
            {
                if(variant.Images == null || !variant.Images.Any())
                {
                    throw new ProductBadRequestException("Loại Sản phẩm cần ít nhất 1 hình ảnh sản phẩm theo màu sắc.");
                }
            }

        }

        private async Task<List<ProductVariant>> ProcessProductVariants(
        IEnumerable<ProductVariantForCreateDto> variantDtos, int productId)
        {
            var productVariants = new List<ProductVariant>();
            

            foreach (var variantDto in variantDtos)
            {
                await ValidateVariant(variantDto);

                var variant = await CreateProductVariant(variantDto, productId);

                productVariants.Add(variant);
            }

            productVariants[0].IsMainVariant = true;

            return productVariants;
        }

        private async Task ValidateVariant(ProductVariantForCreateDto variant)
        {
            if (variant.Images == null || !variant.Images.Any())
            {
                throw new ProductBadRequestException($"At least one image is required for variant {variant.Color}");
            }

            if (string.IsNullOrEmpty(variant.Color))
            {
                throw new ProductBadRequestException("Variant color is required.");
            }

            // Validate stock quantity
            if (variant.StockQuantity < 0)
            {
                throw new ProductBadRequestException("Stock quantity cannot be negative.");
            }

            // Validate discount dates
            if (variant.DiscountStartDate.HasValue && variant.DiscountEndDate.HasValue)
            {
                if (variant.DiscountStartDate > variant.DiscountEndDate)
                {
                    throw new ProductBadRequestException("Discount start date must be before end date.");
                }
            }
        }

        private async Task<ProductVariant> CreateProductVariant(
    ProductVariantForCreateDto variantDto, int productId)
        {
            var variant = _mapper.Map<ProductVariant>(variantDto);
            variant.Images = await ProcessVariantImages(variantDto.Images, productId, variantDto.Color);
            return variant;
        }

        private async Task<List<ProductImage>> ProcessVariantImages(
    IEnumerable<ProductImageForCreateDto> imageDtos, int productId, string variantColor)
        {
            var images = new List<ProductImage>();

            foreach (var imageDto in imageDtos)
            {
                if (imageDto.FileImage == null)
                {
                    throw new ProductBadRequestException($"Invalid image file for variant {variantColor}");
                }

                FileHelper.ValidateFile(imageDto.FileImage);

                string folder = $"HomeDecor/{CloudinaryConstants.Folders.Products}/PRODUCT_ID_{productId}/COLOR_{variantColor}/";
                string imageUrl = await _cloudinaryService.UploadImageAsync(
                    imageDto.FileImage, folder, CloudinaryConstants.FileTypes.ProductImage);

                var image = new ProductImage
                {
                    ImageUrl = imageUrl,
                    IsMainImage = imageDto.IsMainImage
                };
                images.Add(image);
            }
            return images;
        }

        public async Task<ProductDto> UpdateProductAsync(int productId, ProductForUpdateDto productForUpdateDto)
        {
            var product = await _productRepository.GetByIdAsync(productId);

            if (product == null)
            {
                throw new ProductNotFoundException($"{productId}");
            }

            var productForUpdate = _mapper.Map(productForUpdateDto, product);
            _productRepository.Update(productForUpdate);
            await _productRepository.SaveChangesAsync();
            return _mapper.Map<ProductDto>(productForUpdate);
        }

        public async Task DeleteProductAsync(int productId)
        {
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                var product = await _productRepository.GetByIdAsync(productId);
                if (product == null)
                {
                    throw new ProductNotFoundException($"{productId}");
                }

                _productRepository.Remove(product);
                await _productRepository.SaveChangesAsync();
            } catch (Exception ex)
            {
                await _unitOfWork.RollbackAsync();
                _logger.LogError($"Có lỗi sảy ra không thể xóa sản phẩm với ID: {productId}");
                throw ex;
            }
        }
    }
}

