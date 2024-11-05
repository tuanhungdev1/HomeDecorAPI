using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.ProductDtos
{
    public class ProductDetailsDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        [Required]
        [StringLength(100)]
        public string? Measurements { get; set; }
        [StringLength(100)]
        public string? RoomType { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }
        [StringLength(50)]
        public string? Material { get; set; }
        [StringLength(1000)]
        public string? Features { get; set; }
        [StringLength(1000)]
        public string? CareInStructions { get; set; }
        [StringLength(500)]
        public string? WarrantyInfo { get; set; }

        [StringLength(1000)]
        public string? MaintenanceInstructions { get; set; }
        [StringLength(1000)]
        public string? RecommendedCleaningProducts { get; set; }
    }
}
