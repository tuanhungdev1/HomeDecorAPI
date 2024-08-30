using HomeDecorAPI.Application.DTOs.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.CategoryDto {
    public class CategoryDto {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public int? ParentCategoryId { get; set; }

        public string? ParentCategoryName { get; set; }

        public ICollection<CategoryDto>? SubCategories { get; set; }

        public ICollection<ProductDto>? Products { get; set; }
    }
}
