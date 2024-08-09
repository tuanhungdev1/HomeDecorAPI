using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.UnauthorizedException {
    public abstract class UnauthorizedException : Exception {
        protected UnauthorizedException(string message) : base(message) { }
    }
}
