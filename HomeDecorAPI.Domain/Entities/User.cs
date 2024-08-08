﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Domain.Entities {
    public class User : IdentityUser {
        
        [StringLength(100)]
        public required string FullName { get; set; }

        [StringLength(100)]
        public string? City { get; set; }

        [StringLength(100)]
        public string? Country { get; set; }

        [DataType(DataType.ImageUrl)]
        public string? ProfilePicture { get; set; }

        public DateTime? DateOfBirth { get; set; }

    }
}
