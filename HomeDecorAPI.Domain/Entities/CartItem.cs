using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Entities {
    public class CartItem {
        public int Id { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; } // Giá đơn vị tại thời điểm thêm vào giỏ hàng
        public decimal TotalPrice => Quantity * UnitPrice; // Tổng giá cho mỗi mục
        public string SKU { get; set; } // Mã SKU của sản phẩm
        public string Color { get; set; } // Màu sắc (nếu áp dụng)
        public string Size { get; set; } // Kích thước (nếu áp dụng)
        public DateTime AddedAt { get; set; } // Thời gian thêm vào giỏ hàng
        public DateTime UpdatedAt { get; set; } // Thời gian cập nhật gần nhất
        public decimal ItemDiscount { get; set; } // Giảm giá cho mỗi mục (nếu áp dụng)
    }
}
