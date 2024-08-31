using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.NotFoundException {
    public class CategoryNotFoundException : NotFoundException {
        public CategoryNotFoundException(string message) : base(message)
        {
            
        }
    }
}
