using HomeDecorAPI.Domain.Common.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Entities
{
	public class Coupon : BaseEntity
	{
		public string Code { get; set; }
		public string Description { get; set; }
		public decimal DiscountAmount { get; set; }
		public CouponType Type { get; set; }
		public int UsageLimit { get; set; }
		public int UsageCount { get; set; }
		public DateTime ExpiryDate { get; set; }
		public bool IsActive { get; set; }
	}
}
