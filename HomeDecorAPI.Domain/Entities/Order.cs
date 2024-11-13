using HomeDecorAPI.Domain.Common.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Entities {
	public class Order : BaseEntity 
	{
		public string OrderNumber { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime? ShippedDate { get; set; }
		public DateTime? DeliveredDate { get; set; }
		public OrderStatus Status { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		public decimal TotalAmount { get; set; }
		public string ShippingAddress { get; set; }
		public string BillingAddress { get; set; }
		public string UserId { get; set; }
		public User User { get; set; }
		public ICollection<OrderItem> OrderItems { get; set; }
		public Payment Payment { get; set; }
	}
}
