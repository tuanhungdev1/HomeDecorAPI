using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.CartDtos {
    public class UpdateCartItemQuantityDto {
        public int CartItemId { get; set; }
        public int NewQuantity { get; set; }
    }
}
