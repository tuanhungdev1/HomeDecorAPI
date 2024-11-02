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
            var product = await _productRepository.GetByIdAsync(productId);

            if (product == null) {
                throw new ProductNotFoundException($"Product with ID {productId} was not found.");
            }
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> CreateProductAsync(ProductForCreateDto productForCreateDto) {
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                var isMainVariant = false;
                var isMainImageForMainVariant = false;
                var product = _mapper.Map<Product>(productForCreateDto);
                await _productRepository.AddAsync(product);
                await _productRepository.SaveChangesAsync();
                var productVariant = new List<ProductVariant>();
                if(productForCreateDto.Variants == null)
                {
                    _logger.LogError("Cần ít nhất 1 Variant cho sản phẩm");
                    throw new ProductBadRequestException("Cần ít nhất 1 Variant cho sản phẩm. Vui lòng nhập lại đầy đủ thông tin.");
                }
                foreach(var variant in productForCreateDto.Variants)
                {
                    if(variant.IsMainVariant)
                    {
                        isMainVariant = true;
                    }
                    if(variant.Images.Count <= 0 || variant.Images == null)
                    {
                        _logger.LogError("Cần ít nhất 1 Hình ảnh cho một Variant để hiển thị cho sản phẩm");
                        throw new ProductBadRequestException("Cần ít nhất 1 hình ảnh của sản phẩm cho Variant để hiển thị. Vui lòng nhập lại đầy đủ thông tin.");
                    }
                    var productVariantImages = new List<ProductImage>();
                    foreach (var image in variant.Images)
                    {
                        if (image.FileImage == null)
                        {
                            _logger.LogError($"Chưa cập nhật hình ảnh cho Variant là {variant.Color}");
                            throw new ProductBadRequestException($"Chưa cập nhật hình ảnh cho Variant là {variant.Color}");
                        }
                        if (image.IsMainImage)
                        {
                            isMainImageForMainVariant = true;
                        }

                        FileHelper.ValidateFile(image.FileImage);
                        string folder = $"HomeDecor/{CloudinaryConstants.Folders.Products}/{product.Id}/{variant.Color}";
                        string imageUrl = await _cloudinaryService.UploadImageAsync(image.FileImage, folder, CloudinaryConstants.FileTypes.ProductImage);
                        var imageUpload = new ProductImage { ImageUrl = imageUrl, IsMainImage = image.IsMainImage };
                        productVariantImages.Add(imageUpload);
                    }

                    if(!isMainImageForMainVariant)
                    {
                        productVariantImages[0].IsMainImage = true;
                    }

                    var productVariantTemp = _mapper.Map<ProductVariant>(variant);
                    productVariantTemp.Images = productVariantImages;
                    productVariant.Add(productVariantTemp);
                }

                if(!isMainVariant)
                {
                    productVariant[0].IsMainVariant = true;
                }

                product.ProductVariants = productVariant;
                await _productRepository.AddAsync(product);
                await _unitOfWork.CommitAsync();
                return _mapper.Map<ProductDto>(product);
            }
            catch (Exception ex) {
                await _unitOfWork.RollbackAsync();
                _logger.LogError("Có lỗi sảy ra trong quá trình tạo một sản phẩm mới. Vui lòng thử lại");
                throw;
            }
        }

        public async Task<ProductDto> UpdateProductAsync(int productId, ProductForUpdateDto productForUpdateDto) {
            var product = await _productRepository.GetByIdAsync(productId);

            if (product == null) {
                throw new ProductNotFoundException($"Product with ID {productId} was not found.");
            }

            var productForUpdate = _mapper.Map(productForUpdateDto, product);
            _productRepository.Update(productForUpdate);
            await _productRepository.SaveChangesAsync();
            return _mapper.Map<ProductDto>(productForUpdate);
        }

        public async Task DeleteProductAsync(int productId) {
            var product = await _productRepository.GetByIdAsync(productId);
            if (product == null) {
                throw new ProductNotFoundException($"Product with ID {productId} was not found.");
            }

            _productRepository.Remove(product);
            await _productRepository.SaveChangesAsync();
        }
    }
}
