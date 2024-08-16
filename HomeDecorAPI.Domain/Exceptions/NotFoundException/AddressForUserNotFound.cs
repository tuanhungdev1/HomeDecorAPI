using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.NotFoundException {
    public class AddressForUserNotFound : NotFoundException {
        public AddressForUserNotFound(string message) : base(message)
        {
            
        }
    }
}
