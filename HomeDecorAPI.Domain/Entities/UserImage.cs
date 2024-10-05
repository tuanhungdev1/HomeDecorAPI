using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Entities {
    public class UserImage : BaseEntity{
        [Required]
        public required string UserId { get; set; }
        [Required]
        public required string PublicId { get; set; }
        [Required]
        public required string Url { get; set; }
        public User? User { get; set; }
    }
}
