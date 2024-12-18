﻿using HomeDecorAPI.Application.Shared.Validate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HomeDecorAPI.Application.DTOs.UserDtos
{
    public class UserForRegistrationDto
    {
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, ErrorMessage = "First Name must be between 3 and 50 characters", MinimumLength = 3)]
        public required string Firstname { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, ErrorMessage = "Last Name must be between 3 and 50 characters", MinimumLength = 3)]
        public required string Lastname { get; set; }
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, ErrorMessage = "Username must be between 3 and 50 characters", MinimumLength = 3)]
        public required string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "Password must be at least 6 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [StringLength(100, ErrorMessage = "Confirm Password must be at least 6 characters", MinimumLength = 6)]
        public required string Confirm { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }
        [RoleValidation]
        [Required(ErrorMessage = "Roles is required")]
        public required ICollection<string> Roles { get; set; }
    }
}
