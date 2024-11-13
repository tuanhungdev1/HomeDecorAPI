using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Entities
{
	public class Wishlist : BaseEntity
	{
		public int UserId { get; set; }
		public User User { get; set; }
		public ICollection<WishlistItem> WishlistItems { get; set; }
	}
}
