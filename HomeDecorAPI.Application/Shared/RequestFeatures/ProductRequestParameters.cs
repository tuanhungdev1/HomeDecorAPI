using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.RequestFeatures {
    public class ProductRequestParameters : RequestParameters {
        public string? Category { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public int? DiscountPercentage { get; set; }
        public bool? InStock { get; set; }
        public decimal? MinRating { get; set; }
    }
}
