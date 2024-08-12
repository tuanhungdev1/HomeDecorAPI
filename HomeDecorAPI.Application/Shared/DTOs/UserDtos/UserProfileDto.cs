using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.DTOs.UserDtos {
    namespace HomeDecorAPI.Application.Shared.DTOs.UserDtos {
        public class UserProfileDto {
            public Guid Id { get; set; }  

            [StringLength(100)]
            public string FirstName { get; set; }

            [StringLength(100)]
            public string LastName { get; set; }

            [StringLength(100)]
            public string DisplayName { get; set; }

            [EmailAddress]
            public string Email { get; set; }

            [DataType(DataType.ImageUrl)]
            public string ProfilePicture { get; set; }

            public DateTime DateOfBirth { get; set; }
        }
    }

}
