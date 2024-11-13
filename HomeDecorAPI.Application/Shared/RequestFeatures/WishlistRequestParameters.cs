using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.RequestFeatures
{
	public class WishlistRequestParameters : RequestParameters
	{
        public string? SortKey { get; set; }
        public int? CategoryId { get; set; }
		public int? BrandId { get; set; }
		public DateTime? DateAddedFrom { get; set; }
		public DateTime? DateAddedTo { get; set; }
		public double? MinRating { get; set; }
		public decimal? MinPrice { get; set; }
		public decimal? MaxPrice { get; set; }
	}
}
