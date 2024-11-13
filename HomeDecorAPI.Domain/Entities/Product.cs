using HomeDecorAPI.Domain.Common.enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeDecorAPI.Domain.Entities {
    public class Product : BaseEntity {

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public required string Name { get; set; }

        [Required]
        [StringLength(300)]
        public string ShortDescription { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[A-Z0-9]+$")]
        public required string BaseSKU { get; set; }

        [Required]
        [StringLength(100)]
        public required string Measurements { get; set; }

        [Required]
        public ProductStatus Status { get; set; } = ProductStatus.Draft;

        [Required]
        public bool IsPublished { get; set; } = false;
        public int? CategoryId { get; set; }
        public int? BrandId { get; set; }
        public Brand? Brand { get; set; }
        public int? SupplierId { get; set; }
        public Supplier? Supplier { get; set; }
        public ProductDetails? ProductDetails { get; set; }
        public ICollection<ProductVariant>? ProductVariants { get; set; } = new List<ProductVariant>();
		public ICollection<Review>? Reviews { get; set; } = new List<Review>();
		public Category? Categories { get; set; }
    }
}
