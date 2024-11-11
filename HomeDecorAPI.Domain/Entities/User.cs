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
        public string? Firstname { get; set; }
        [StringLength(100)]
        public string? Lastname { get; set; }
        [StringLength(100)]
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
        public string? ImageUrl { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
        public string Status { get; set; } = "Active";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public virtual ICollection<Address>? Addresses { get; set; } = new List<Address>();
        public virtual ICollection<FavoriteProduct>? FavoriteProducts { get; set; } = new List<FavoriteProduct>();
    }
}
