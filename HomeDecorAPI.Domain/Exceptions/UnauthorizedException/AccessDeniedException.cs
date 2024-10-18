using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.UnauthorizedException {
    public class AccessDeniedException : Exception {
        public AccessDeniedException() : base("Bạn không có quyền truy cập vào trang này. Chỉ quản trị viên (Admin) mới được phép truy cập.") {
        }

        public AccessDeniedException(string message)
            : base(message) {
        }

        public AccessDeniedException(string message, Exception inner)
            : base(message, inner) {
        }
    }
}
