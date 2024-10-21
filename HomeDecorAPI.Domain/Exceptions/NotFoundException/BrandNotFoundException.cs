using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.NotFoundException
{
    public class BrandNotFoundException : NotFoundException
    {
        public BrandNotFoundException(int id) : base($"Không tìm thấy Brand với ID: {id}")
        {
            
        }
    }
}
