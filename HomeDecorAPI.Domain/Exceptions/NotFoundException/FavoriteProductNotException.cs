using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.NotFoundException {
    public class FavoriteProductNotException : NotFoundException {
        public FavoriteProductNotException(string productId): base($"The product with ID {productId} is not in the user's wishlist.")
        {
            
        }
    }
}
