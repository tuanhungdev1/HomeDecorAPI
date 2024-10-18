using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.NotFoundException {
    public class LoginException : NotFoundException {
        public LoginException() : base("Username hoặc Password không chính xác!")
        {
            
        }
    }
}
