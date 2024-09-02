using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Entities {
    public class User : IdentityUser {
        [StringLength(100)]
        public string? FirstName { get; set; }
        [StringLength(100)]
        public string? LastName { get; set; }

        [StringLength(100)]
        public string? DisplayName { get; set; }

        [DataType(DataType.ImageUrl)]
        public string? ProfilePicture { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string? RefreshToken { get; set; }

        public DateTime? RefreshTokenExpiryTime { get; set; }

        public virtual ICollection<Address>? Addresses { get; set; } = new List<Address>();
        public virtual ICollection<FavoriteProduct>? FavoriteProducts { get; set; } = new List<FavoriteProduct>();
    }
}
