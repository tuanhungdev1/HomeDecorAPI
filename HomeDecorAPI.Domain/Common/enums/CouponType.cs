using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Common.enums
{
	public enum CouponType
	{
		FixedAmount,      // Giảm giá số tiền cố định
		Percentage,       // Giảm giá theo tỷ lệ phần trăm
		FreeShipping,     // Miễn phí vận chuyển
		BuyOneGetOne,     // Mua 1 tặng 1
						  // Các kiểu khác có thể thêm vào nếu cần
	}
}
