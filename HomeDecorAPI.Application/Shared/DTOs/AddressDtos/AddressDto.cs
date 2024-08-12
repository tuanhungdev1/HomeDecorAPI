using HomeDecorAPI.Application.Shared.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.DTOs.AddressDtos {
    public class AddressDto {
        public Guid Id { get; set; }
        
        public required string DisplayName { get; set; }
        
        public required string PhoneNumber { get; set; }
        
        public required string AddressLine { get; set; }

        public required string City { get; set; }

        public string? State { get; set; }
        
        public required string Country { get; set; }
        
        public required string PostalCode { get; set; }

        public bool IsDefault { get; set; }

        public AddressType Type { get; set; }
    }
}
