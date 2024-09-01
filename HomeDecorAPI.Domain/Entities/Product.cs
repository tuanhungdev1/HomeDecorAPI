using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeDecorAPI.Domain.Entities {
    public class Product {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters.")]
        public required string Name { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public required string Description { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Original Price must be a positive value.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal OriginalPrice { get; set; }

        [Range(0, 100, ErrorMessage = "Discount Percentage must be between 0 and 100.")]
        public int? DiscountPercentage { get; set; }

        public DateTime? DiscountEndDate { get; set; } // Ngày hết hạn giảm giá

        [Required]
        [Url(ErrorMessage = "Invalid URL format.")]
        public required string ImageUrl { get; set; }

        public DateTime? IsNewExpiryDate { get; set; } // Ngày hết hạn trạng thái mới

        [Required]
        [StringLength(50, ErrorMessage = "SKU cannot exceed 50 characters.")]
        [RegularExpression(@"^[A-Z0-9]+$", ErrorMessage = "SKU must be alphanumeric and uppercase.")]
        public required string SKU { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Measurements cannot exceed 100 characters.")]
        public required string Measurements { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Stock Quantity must be a non-negative integer.")]
        public required int StockQuantity { get; set; }

        public bool IsDiscountActive {
            get {
                return DiscountPercentage.HasValue && DiscountEndDate.HasValue && DiscountEndDate > DateTime.UtcNow;
            }
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? CreatedDate { get; set; } = DateTime.UtcNow;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedDate { get; set; } = DateTime.UtcNow;

        // Navigation property to categories
        public ICollection<Category>? Categories { get; set; }
        //public ICollection<Review>? Reviews { get; set; } = new List<Review>();
    }
}
