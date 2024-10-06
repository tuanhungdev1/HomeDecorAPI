using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.ProductDtos;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using HomeDecorAPI.Domain.Entities;
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

        public ProductService(IProductRepository productRepository, IMapper mapper) {
            _productRepository = productRepository;
            _mapper = mapper;
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
            var product = _mapper.Map<Product>(productForCreateDto);
            await _productRepository.AddAsync(product);
            await _productRepository.SaveChangesAsync();
            return _mapper.Map<ProductDto>(product);
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
