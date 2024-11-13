using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.AspNetCore.Http;

namespace HomeDecorAPI.Application.DTOs.UserDtos
{
    public class UserForCreateDto
    {
        [Required]
        public required string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }
        [Required]
		[Compare("Password", ErrorMessage = "Password and Confirm Password must match.")]
		public string ConfirmPassword { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        public string? Displayname { get; set; }
        [StringLength(300)]
        public string? Description { get; set; }
        [StringLength(500)]
        public string? Address { get; set; }
        [StringLength(50)]
        public string? Country { get; set; }
        [StringLength(50)]
        public string? City { get; set; }
        [Range(0, 300)]
        public int? Age { get; set; }
        public IFormFile? FileImage { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Status { get; set; } = "Active";
        public IEnumerable<string> Roles { get; set; } = new List<string>();
    }
}
