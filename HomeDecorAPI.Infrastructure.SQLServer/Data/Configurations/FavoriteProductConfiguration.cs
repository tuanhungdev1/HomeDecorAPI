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
        public void Configure(EntityTypeBuilder<FavoriteProduct> builder) { 
            builder.HasKey(fp => new {fp.UserId, fp.ProductId});

            builder.HasOne(fp => fp.User)
                .WithMany(u => u.FavoriteProducts)
                .HasForeignKey(fp => fp.UserId);

            builder.HasOne(fp => fp.Product)
                .WithMany()
                .HasForeignKey(fp => fp.ProductId);
        }
    }
}
