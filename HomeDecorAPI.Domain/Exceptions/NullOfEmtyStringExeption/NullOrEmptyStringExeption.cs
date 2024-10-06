using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.NullOfEmtyStringExeption
{
    public abstract class NullOrEmptyStringExeption : Exception
    {

        protected NullOrEmptyStringExeption(string message) : base(message)
        {

        }
    }
}
