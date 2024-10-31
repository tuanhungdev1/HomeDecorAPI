using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.RequestFeatures
{
    public class SupplierRequestParameters: RequestParameters
    {
        public bool? IsActive { get; set; }
        public string? Name { get; set; }
        public string? SortKey { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
