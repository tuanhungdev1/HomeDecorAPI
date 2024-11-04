using HomeDecorAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace HomeDecorAPI.Application.DTOs.SupplierDtos
{
    public class SupplierForUpdateDto
    {
        [Required]
        [StringLength(100)]
        public required string Name { get; set; }
        [StringLength(300)]
        public string? Description { get; set; }
        [Required]
        [StringLength(100)]
        public required string ContactPerson { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(100)]
        public required string Email { get; set; }
        [Phone]
        [StringLength(20)]
        public string? Phone { get; set; }
        [StringLength(200)]
        public string? Address { get; set; }
        [StringLength(50)]
        public string? City { get; set; }
        [StringLength(50)]
        public string? Country { get; set; }
        public IFormFile? LogoFile { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleteImage { get; set; } = false;

    }
}
