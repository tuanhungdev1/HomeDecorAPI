using CloudinaryDotNet.Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.Validate {
    public class RoleValidationAttribute : ValidationAttribute {
        private readonly List<string> _roles = new List<string>() { "Admin", "Customer" };

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext) {
            if(value is List<string> roles) {
                foreach(var role in roles) {
                    if(!_roles.Contains(role)) {
                        return new ValidationResult($"The role '{role}' is not valid. Allowed roles are: {string.Join(", ", roles)}.");
                    }
                }
            }

            return ValidationResult.Success;
        }
    }
}
