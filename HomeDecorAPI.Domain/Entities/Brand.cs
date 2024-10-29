using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Entities {
    public class Brand : BaseEntity {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(300)]
        public string? Description { get; set; }
        public string? LogoUrl { get; set; }
        public bool IsActive { get; set; } = true;
        public virtual ICollection<Product>? Products { get; set; }
    }
}
