using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.BadRequestException
{
    public class ProductBadRequestException : BadRequestException
    {
        public ProductBadRequestException(string message) : base(message)
        {
            
        }
    }
}
