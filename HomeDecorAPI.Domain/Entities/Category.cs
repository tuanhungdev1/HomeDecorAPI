using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeDecorAPI.Domain.Entities {
    public class Category {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Category Name must be between 2 and 100 characters.")]
        public required string Name { get; set; }

        [StringLength(500, MinimumLength = 2, ErrorMessage = "Category Description must be between 2 and 500 characters.")]
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }

        // Foreign key to the parent category
        public int? ParentCategoryId { get; set; }

        // Navigation property to the parent category
        [ForeignKey("ParentCategoryId")]
        public Category? ParentCategory { get; set; }

        // Navigation property to the child categories
        public ICollection<Category>? SubCategories { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
