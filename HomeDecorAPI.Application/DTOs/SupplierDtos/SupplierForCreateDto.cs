using HomeDecorAPI.Domain.Entities;
using Microsoft.AspNetCore.Http.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace HomeDecorAPI.Application.DTOs.SupplierDtos
{
    public class SupplierForCreateDto
    {
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
        [StringLength(100)]
        public string? Email { get; set; }
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
    }
}
