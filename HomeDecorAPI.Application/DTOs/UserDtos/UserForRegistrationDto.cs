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
        public ICollection<string>? Roles { get; init; }
    }
}
