using HomeDecorAPI.Application.Shared.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.DTOs.AddressDtos {
    public class AddressForUpdateDto {
        [Required(ErrorMessage = "Display name is required.")]
        [StringLength(100, ErrorMessage = "Display name cannot exceed 100 characters.")]
        public string DisplayName { get; set; } = null!;

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Invalid phone number format.")]
        [StringLength(15, ErrorMessage = "Phone number cannot exceed 15 characters.")]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "Address line is required.")]
        [StringLength(200, ErrorMessage = "Address line cannot exceed 200 characters.")]
        public string AddressLine { get; set; } = null!;

        [Required(ErrorMessage = "City is required.")]
        [StringLength(100, ErrorMessage = "City cannot exceed 100 characters.")]
        public string City { get; set; } = null!;

        [StringLength(100, ErrorMessage = "State cannot exceed 100 characters.")]
        public string? State { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        [StringLength(100, ErrorMessage = "Country cannot exceed 100 characters.")]
        public string Country { get; set; } = null!;

        [Required(ErrorMessage = "Postal code is required.")]
        [StringLength(20, ErrorMessage = "Postal code cannot exceed 20 characters.")]
        public string PostalCode { get; set; } = null!;

        public bool IsDefault { get; set; } = false;

        [Required(ErrorMessage = "Address type is required.")]
        public AddressType Type { get; set; } = AddressType.Home;
    }
}
