using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.NullOfEmtyStringExeption {
    public class WishlistForUserIsEmptyException : NullOrEmptyStringExeption {
        public WishlistForUserIsEmptyException(string userId): base($"Wishlist for User ID: {userId}")
        {
            
        }
    }
}
