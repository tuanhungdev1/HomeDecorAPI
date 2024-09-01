using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Entities {
    public class Cart {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CouponCode { get; set; } // Mã giảm giá đã áp dụng
        public decimal DiscountAmount { get; set; } // Số tiền giảm giá
        public decimal SubTotal => CartItems.Sum(item => item.TotalPrice); // Tổng giá trước khi giảm giá
        public decimal TotalAmount => SubTotal - DiscountAmount; // Tổng giá sau khi giảm giá
        public string Currency { get; set; } // Loại tiền tệ
        public string Status { get; set; } // Trạng thái giỏ hàng (ví dụ: Active, Abandoned, Converted to Order)
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
