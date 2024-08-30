using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.ProductDtos {
    public class ProductForCreateDto {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters.")]
        public required string Name { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public required string Description { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Original Price must be a positive value.")]
        public decimal OriginalPrice { get; set; }

        [Range(0, 100, ErrorMessage = "Discount Percentage must be between 0 and 100.")]
        public int? DiscountPercentage { get; set; }

        [Required]
        [Url(ErrorMessage = "Invalid URL format.")]
        public required string ImageUrl { get; set; }

        public bool IsNew { get; set; } = true;

        [Required]
        [StringLength(50, ErrorMessage = "SKU cannot exceed 50 characters.")]
        [RegularExpression(@"^[A-Z0-9]+$", ErrorMessage = "SKU must be alphanumeric and uppercase.")]
        public required string SKU { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Measurements cannot exceed 100 characters.")]
        public required string Measurements { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Stock Quantity must be a non-negative integer.")]
        public int StockQuantity { get; set; }

        public DateTime? DiscountEndDate { get; set; }

        public DateTime? IsNewExpiryDate { get; set; }
    }
}
