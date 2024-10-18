using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.NotFoundException {
    public sealed class UserNotFoundException : NotFoundException {
        public UserNotFoundException(string userId) : base($"User with ID: {userId} was not found.")
        {
            
        }

        public UserNotFoundException() : base("Không tìm thấy tài khoản người dùng trong database.")
        {
            
        }
    }
}
