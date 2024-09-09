using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.DTOs.CartDtos {
    public class AddToCartDto {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
