using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.ProductDtos;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Shared.Constants;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using HomeDecorAPI.Domain.Entities;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public ProductService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<(IEnumerable<ProductDto>, MetaData)> GetAllProductsAsync(int pageNumber, int pageSize) {
            var products = await _repositoryManager.ProductRepository.GetAllAsync();

            var productDtoList = _mapper.Map<IEnumerable<ProductDto>>(products);

            var pagedResult =  PagedList<ProductDto>.ToPagedList(productDtoList, pageNumber, pageSize);

            return (pagedResult, pagedResult.MetaData);
        }

        public async Task<ProductDto> GetProdductByIdAsync(int productId) {
            var product = await _repositoryManager.ProductRepository.GetByIdAsync(productId);

            if (product == null) {
                throw new ProductNotFoundException($"Product with ID {productId} was not found.");
            }
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> CreateProductAsync(ProductForCreateDto productForCreateDto) {
            var product = _mapper.Map<Product>(productForCreateDto);

            await _repositoryManager.ProductRepository.AddAsync(product);

            await _repositoryManager.SaveChangesAsync();

            return _mapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> UpdateProductAsync(int productId, ProductForUpdateDto productForUpdateDto) {
            var product = await _repositoryManager.ProductRepository.GetByIdAsync(productId);

            if (product == null) {
                throw new ProductNotFoundException(Messages.Error.EntityNotFound("Product", productId));
            }

            var productForUpdate = _mapper.Map(productForUpdateDto, product);

            await _repositoryManager.ProductRepository.UpdateAsync(productForUpdate);
            await _repositoryManager.SaveChangesAsync();

            return _mapper.Map<ProductDto>(productForUpdate);
        }

        public async Task DeleteProductAsync(int productId) {

            var product = await _repositoryManager.ProductRepository.GetByIdAsync(productId);
            if (product == null) {
                throw new ProductNotFoundException(Messages.Error.EntityNotFound("Product", productId));
            }

            await _repositoryManager.ProductRepository.RemoveAsync(product);
            await _repositoryManager.SaveChangesAsync();
        }
    }
}
