using HomeDecorAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.Data.Configurations {
    public class FavoriteProductConfiguration : IEntityTypeConfiguration<FavoriteProduct> {
        public void Configure(EntityTypeBuilder<Category> builder) { }
    }
}
