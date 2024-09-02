using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.WishlistDtos {
    public class AddProductForWishlistDto {
        [Required(ErrorMessage = "UserID is required.")]
        public Guid UserId { get; set; }
        [Required(ErrorMessage = "ProductID is required.")]
        public int ProductId { get; set; }
    }
}
