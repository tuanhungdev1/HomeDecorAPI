using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Entities
{
    public class ProductImage : BaseEntity
    {
        public int ProductVariantId { get; set; }
        [Required]
        [Url]
        public required string ImageUrl { get; set; }
        public bool IsMainImage { get; set; } = false;
        public ProductVariant? ProductVariant { get; set; }
    }
}
