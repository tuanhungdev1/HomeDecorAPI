using HomeDecorAPI.Application.Shared.Validate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HomeDecorAPI.Application.DTOs.UserDtos
{
    public class UserForRegistrationDto
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, ErrorMessage = "Username must be between 3 and 50 characters", MinimumLength = 3)]
        public required string UserName { get; init; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "Password must be at least 6 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public required string Password { get; init; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? Email { get; init; }
        [RoleValidation]
        [Required(ErrorMessage = "Roles is required")]
        public required ICollection<string> Roles { get; init; }
    }
}
