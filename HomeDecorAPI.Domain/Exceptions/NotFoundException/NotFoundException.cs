using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.NotFoundException
{
    public abstract class NotFoundException : Exception
    {
        protected NotFoundException(string message)
        : base(message) { }
    }
}
