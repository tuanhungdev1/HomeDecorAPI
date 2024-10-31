using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.CategoryDtos {
    public class CategoryForCreateDto {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Category Name must be between 2 and 100 characters.")]
        public string Name { get; set; }

        [StringLength(500, MinimumLength = 2, ErrorMessage = "Category Description must be between 2 and 500 characters.")]
        public string? Description { get; set; }

        [Url(ErrorMessage = "Invalid URL format.")]
        public string? ImageUrl { get; set; }
        public bool? IsActive { get; set; } = true;
        public int? ParentCategoryId { get; set; }
    }
}
