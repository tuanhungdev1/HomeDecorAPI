﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.NotFoundException {
    public class ProductNotFoundException : NotFoundException {
        public ProductNotFoundException(string productId) : base($"Product with ID: {productId} was not found.")
        {
            
        }
    }
}
