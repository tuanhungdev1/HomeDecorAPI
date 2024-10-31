using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.NotFoundException {
    public class CategoryNotFoundException : NotFoundException {
        public CategoryNotFoundException(int id) : base($"Không tìm thấy Category với ID: {id}.")
        {
            
        }
    }
}
