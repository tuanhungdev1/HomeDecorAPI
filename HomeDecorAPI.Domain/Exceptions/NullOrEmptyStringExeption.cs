using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions {
    public class NullOrEmptyStringExeption : Exception {
        public NullOrEmptyStringExeption() {

        }

        public NullOrEmptyStringExeption(string message) : base(message) {

        }

        public NullOrEmptyStringExeption(string message, Exception inner) : base(message, inner) {

        }
    }
}
