using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.NotFoundException {
    public class UserImageNotFoundException : NotFoundException {
        public UserImageNotFoundException(string userId) : base($"User with ID {userId} does not have an avatar.")
        {
            
        }
    }
}
