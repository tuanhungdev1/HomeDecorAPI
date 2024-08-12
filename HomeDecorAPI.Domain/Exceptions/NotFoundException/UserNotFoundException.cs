using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.NotFoundException {
    public sealed class UserNotFoundException : NotFoundException {
        public UserNotFoundException(string message) : base(message)
        {
            
        }
    }
}
