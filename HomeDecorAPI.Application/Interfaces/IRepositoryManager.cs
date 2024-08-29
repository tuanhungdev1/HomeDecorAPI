using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Interfaces {
    public interface IRepositoryManager {
        public IAddressRepository AddressRepository { get; }
        
    }
}
