using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeDecorAPI.Domain.Entities {
    public class Category : BaseEntity {

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public required string Name { get; set; }

        [StringLength(500, MinimumLength = 2)]
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public bool? IsActive { get; set; } = true;
        public int? ParentCategoryId { get; set; }
        public Category? ParentCategory { get; set; }
        public ICollection<Category>? SubCategories { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
