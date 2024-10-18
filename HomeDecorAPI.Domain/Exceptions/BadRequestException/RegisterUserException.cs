using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.BadRequestException {
    public class RegisterUserException : BadRequestException {
        public RegisterUserException() : base("Thông tin đăng kí của người dùng không hợp lệ.")
        {
            
        }
    }
}
