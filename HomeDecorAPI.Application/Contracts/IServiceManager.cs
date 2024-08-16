using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Contracts {
    public interface IServiceManager {
        IAuthenticationService AuthenticationService { get; }
        IUserService UserService { get; }
        IFileUploadService FileUploadService { get; }
        IAddressService AddressService { get; }
    }
}
