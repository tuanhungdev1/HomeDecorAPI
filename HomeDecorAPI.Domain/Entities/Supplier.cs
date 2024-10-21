using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Entities {
    public class Supplier : BaseEntity {

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        [Required]
        [StringLength(100)]
        public string ContactPerson { get; set; }
        [Required]
        [EmailAddress]
        [StringLength (100)]
        public string Email { get; set; }
        [Phone]
        [StringLength (20)]
        public string Phone { get; set; }
        [StringLength(200)]
        public string  Address { get; set; }
        [StringLength (50)]
        public string City { get; set; }
        [StringLength (50)]
        public string Country { get; set; }
        public string LogoUrl { get; set; }
        public bool IsActive { get; set; } = true;
        public virtual ICollection<Brand> Brands { get; set; }
    }
}
