using HomeDecorAPI.Domain.Common.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace HomeDecorAPI.Domain.Entities {
	public class Cart : BaseEntity
	{
		public int UserId { get; set; }
		public CartStatus Status { get; set; } = CartStatus.Active;
		public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
		public DateTime ExpiryDate { get; set; } = DateTime.UtcNow.AddDays(30);
		public User User { get; set; }
		public ICollection<CartItem> CartItems { get; set; }
	}
}