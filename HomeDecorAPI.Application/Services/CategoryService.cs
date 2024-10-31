using AutoMapper;
using HomeDecorAPI.Application.Contracts;
using HomeDecorAPI.Application.DTOs.CategoryDto;
using HomeDecorAPI.Application.DTOs.CategoryDtos;
using HomeDecorAPI.Application.Interfaces;
using HomeDecorAPI.Domain.Exceptions.NotFoundException;
using HomeDecorAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeDecorAPI.Application.Shared.RequestFeatures;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace HomeDecorAPI.Application.Services {
    public class CategoryService : ICategoryService {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper) {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<(IEnumerable<CategoryDto> categories, MetaData metaData)> GetAllCategoriesAsync(CategoryRequestParameters categoryRequestParameters) {
            var categories = await _categoryRepository.GetAllCategories(categoryRequestParameters);

            //var categoriesGroupByParent = categories.Where(c => c.ParentCategoryId.HasValue).GroupBy(c => c.ParentCategoryId).ToDictionary(g => g.Key, g => g.ToList());

            //List<Category> BuildCategoryTree(int? parentId)
            //{
            //    if (!categoriesGroupByParent.ContainsKey(parentId))
            //        return new List<Category>();

            //    var categories = categoriesGroupByParent[parentId];
            //    foreach(var category in categories)
            //    {
            //        category.SubCategories = BuildCategoryTree(category.Id);
            //    }

            //    return categories;
            //}

            //var rootCategories = BuildCategoryTree(null);
            var categoryDtos = _mapper.Map<IEnumerable<CategoryDto>>(categories);
            return (categories: categoryDtos, metaData: categories.MetaData);
        }

        public async Task<CategoryDto> GetCategoryByIdAsync(int categoryId) {
            var category = await _categoryRepository.GetByIdAsync(categoryId);

            if (category == null)
                throw new CategoryNotFoundException(categoryId);

            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<CategoryDto> CreateCategoryAsync(CategoryForCreateDto categoryForCreateDto) {

            var category = _mapper.Map<Category>(categoryForCreateDto);
            if(categoryForCreateDto.ParentCategoryId.HasValue)
            {
                var parentCategory = await _categoryRepository.GetByIdAsync(categoryForCreateDto.ParentCategoryId.Value);

                if (parentCategory == null)
                    throw new CategoryNotFoundException(categoryForCreateDto.ParentCategoryId.Value);


                var subCategories = await _categoryRepository.GetSubcategoriesByParentCategory(parentCategory.Id);
                subCategories.Add(category);
                await _categoryRepository.SaveChangesAsync();
                
            } else
            {
               
                await _categoryRepository.AddAsync(category);
            }

            await _categoryRepository.SaveChangesAsync();
            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<CategoryDto> UpdateCategoryAsync(int categoryId, CategoryForUpdateDto categoryForUpdateDto) {
            var category = await _categoryRepository.GetByIdAsync(categoryId);

            if (category == null)
                throw new CategoryNotFoundException(categoryId);

            _mapper.Map(categoryForUpdateDto, category);

            _categoryRepository.Update(category);
            await _categoryRepository.SaveChangesAsync();

            return _mapper.Map<CategoryDto>(category);
        }

        public async Task DeleteCategoryAsync(int categoryId) {
            var category = await _categoryRepository.GetByIdAsync(categoryId);

            if (category == null)
                throw new CategoryNotFoundException(categoryId);

            _categoryRepository.Remove(category);
            await _categoryRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<CategoryDto>> GetSubCategoriesAsync(int parentCategoryId) {
            var category = await _categoryRepository.GetByIdAsync(parentCategoryId);

            if (category == null)
                throw new CategoryNotFoundException(parentCategoryId);
            var subCategories = await _categoryRepository.GetSubcategoriesByParentCategory(parentCategoryId);

            return _mapper.Map<IEnumerable<CategoryDto>>(subCategories);
        }
    }
}
