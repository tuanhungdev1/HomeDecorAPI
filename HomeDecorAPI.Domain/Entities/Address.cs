using HomeDecorAPI.Application.Shared.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Entities {
    public class Address {
        [Key]
        [Column("AddressId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Display name is a required field.")]
        [StringLength(100)]
        public required string DisplayName { get; set; }
        [Required(ErrorMessage = "Phone number is a required field.")]
        [StringLength(100)]
        public required string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Address line is a required field.")]
        [StringLength(300)]
        public required string AddressLine { get; set; }

        [Required(ErrorMessage = "City is a required field.")]
        [StringLength(100)]
        public required string City { get; set; }

        [StringLength(100)]
        public string? State { get; set; }
        [Required(ErrorMessage = "Country is a required field.")]

        [StringLength(100)]
        public required string Country { get; set; }
        [Required(ErrorMessage = "Postal code is a required field.")]

        [StringLength(20)]
        public required string PostalCode { get; set; }

        public bool IsDefault { get; set; }

        public AddressType Type { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
