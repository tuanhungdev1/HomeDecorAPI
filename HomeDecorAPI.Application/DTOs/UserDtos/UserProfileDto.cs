using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.DTOs.UserDtos {
    namespace HomeDecorAPI.Application.Shared.DTOs.UserDtos {
        public class UserProfileDto {
            public string? Id { get; set; }
            public string? Username { get; set; }
            public string? Email { get; set; }
            public string? Firstname { get; set; }
            public string? Lastname { get; set; }
            public string? Address { get; set; }
            public int? Age { get; set; }
            public string? Displayname { get; set; }
            public string? PhoneNumber { get; set; }
            public string? ProfilePicture { get; set; }
            public DateOnly? DateOfBirth { get; set; }
            public IEnumerable<string>? Roles { get; set; } = new List<string>();
        }
    }

}
