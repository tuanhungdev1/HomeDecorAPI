using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.Data.Configurations {
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole> {
        public void Configure(EntityTypeBuilder<IdentityRole> builder) {
            builder.HasData(
            new IdentityRole {
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole {
                Name = "Customer",
                NormalizedName = "CUSTOMER"
            },
            new IdentityRole {
                Name = "Manager",
                NormalizedName = "MANAGER"
            },
            new IdentityRole {
                Name = "ContentCreator",
                NormalizedName = "ContentCreator"
            }
            );
        }
    }
}
