using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.NotFoundException
{
    public class SupplierNotFoundException : NotFoundException
    {
        public SupplierNotFoundException(int id) : base($"Không tìm thấy Supplier ID: {id}")
        {

        }
    }
}
