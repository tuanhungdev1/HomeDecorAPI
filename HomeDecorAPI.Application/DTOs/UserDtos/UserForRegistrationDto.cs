using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HomeDecorAPI.Application.DTOs.UserDtos
{
    public class UserForRegistrationDto
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, ErrorMessage = "Username must be between 3 and 50 characters", MinimumLength = 3)]
        public string? UserName { get; init; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "Password must be at least 6 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string? Password { get; init; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? Email { get; init; }

        [Phone(ErrorMessage = "Invalid phone number format")]
        public string? PhoneNumber { get; init; }

        [Required(ErrorMessage = "Full name is required")]
        [StringLength(100, ErrorMessage = "Full name must be at most 100 characters")]
        public string? FullName { get; set; }

        [StringLength(100, ErrorMessage = "City name must be at most 100 characters")]
        public string? City { get; set; }

        [StringLength(100, ErrorMessage = "Country name must be at most 100 characters")]
        public string? Country { get; set; }

        [DataType(DataType.ImageUrl, ErrorMessage = "Invalid URL format")]
        public string? ProfilePicture { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public ICollection<string>? Roles { get; init; }
    }
}
