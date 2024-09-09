using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.NotFoundException {
    public class CartNotFoundException : NotFoundException {
        public CartNotFoundException(string message) : base(message)
        {
            
        }
    }
}
