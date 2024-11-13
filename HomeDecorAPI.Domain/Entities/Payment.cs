using HomeDecorAPI.Domain.Common.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Entities
{
	public class Payment : BaseEntity
	{
		public int OrderId { get; set; }
		public Order Order { get; set; }
		public string UserId { get; set; }
		public User User { get; set; }
		public PaymentMethod PaymentMethod { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		public decimal Amount { get; set; }
		public PaymentStatus Status { get; set; }
		public DateTime PaymentDate { get; set; }
	}
}
