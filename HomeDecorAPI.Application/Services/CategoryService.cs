using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.CategoryDto;
using HomeDecorAPI.Application.DTOs.CategoryDtos;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Application.Shared.Constants;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using HomeDecorAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public CategoryService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync() {
            var categories = await _repositoryManager.CategoryRepository.GetAllAsync();

            var categoryDtoList = _mapper.Map<IEnumerable<CategoryDto>>(categories);

            return categoryDtoList;
        }

        public async Task<CategoryDto> GetCategoryByIdAsync(int categoryId) {
            var category = await _repositoryManager.CategoryRepository.GetByIdAsync(categoryId);

            if (category == null)
                throw new CategoryNotFoundException(Messages.Error.EntityNotFound("Category", categoryId));

            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<CategoryDto> CreateCategoryAsync(CategoryForCreateDto categoryForCreateDto) {
            var category = _mapper.Map<Category>(categoryForCreateDto);

            await _repositoryManager.CategoryRepository.AddAsync(category);

            await _repositoryManager.SaveChangesAsync();

            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<CategoryDto> UpdateCategoryAsync(int categoryId, CategoryForUpdateDto categoryForUpdateDto) {
            var category = await _repositoryManager.CategoryRepository.GetByIdAsync(categoryId);

            if(category == null)
                throw new CategoryNotFoundException(Messages.Error.EntityNotFound("Category", categoryId));

            var categoryForUpdate = _mapper.Map(categoryForUpdateDto, category);

            await _repositoryManager.CategoryRepository.UpdateAsync(categoryForUpdate);
            await _repositoryManager.SaveChangesAsync();

            return _mapper.Map<CategoryDto>(categoryForUpdate);
        }

        public async Task DeleteCategoryAsync(int categoryId) {
            var category = await _repositoryManager.CategoryRepository.GetByIdAsync(categoryId);

            if (category == null)
                throw new CategoryNotFoundException(Messages.Error.EntityNotFound("Category", categoryId));

            await _repositoryManager.CategoryRepository.RemoveAsync(category);
            await _repositoryManager.SaveChangesAsync();
        }

        public async Task<IEnumerable<CategoryDto>> GetSubCategoriesAsync(int parentCategoryId) {
            var subCategories = await _repositoryManager.CategoryRepository.GetSubcategoriesByParentCategory(parentCategoryId);

            if (subCategories == null)
                throw new CategoryNotFoundException(Messages.Error.EntityNotFound("Parent Category", parentCategoryId));

            return _mapper.Map<IEnumerable<CategoryDto>>(subCategories);
        }
    }
}
