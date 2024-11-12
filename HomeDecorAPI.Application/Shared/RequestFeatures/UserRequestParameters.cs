using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.RequestFeatures
{
    public class UserRequestParameters : RequestParameters
    {
        public string? SortKey { get; set; }
        public string? Status { get; set; } 
        public int? StartAge { get; set; } 
        public int? EndAge { get; set; } 
        public string? Country { get; set; }
        public string? City { get; set; }
        public DateTime? CreatedAfter { get; set; } 
        public DateTime? CreatedBefore { get; set; } 
        public List<string>? Roles { get; set; } 
    }
}
