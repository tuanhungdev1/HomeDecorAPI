﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Exceptions.UnauthorizedException {
    public class UserUnauthorizedException : UnauthorizedException {
        public UserUnauthorizedException(string message) : base(message) 
        {
            
        }
    }
}
