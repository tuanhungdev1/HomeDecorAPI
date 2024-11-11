using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.UserDtos
{
    public class UserForUpdateDto
    {
        [StringLength(100)]
        public string? FirstName { get; set; }
        [StringLength(100)]
        public string? LastName { get; set; }
        [StringLength(100)]
        public string? DisplayName { get; set; }
        [Range(0,200)]
        public int? Age { get; set; }
        [StringLength(300)]
        public string? Description { get; set; }
        [StringLength(500)]
        public string? Address { get; set; }
        [StringLength(50)]
        public string? Country { get; set; }
        [StringLength(50)]
        public string? City { get; set; }
        public IList<string>? Roles { get; set; }
        public IFormFile? FileImage { get; set; }
        public string Status { get; set; }
        public bool isDeleteImage { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
