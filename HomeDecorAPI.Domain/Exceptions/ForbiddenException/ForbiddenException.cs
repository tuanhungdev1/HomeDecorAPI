using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.ForbiddenException {
    public abstract class ForbiddenException : Exception {
        protected ForbiddenException(string message) : base(message) { }
    }
}
