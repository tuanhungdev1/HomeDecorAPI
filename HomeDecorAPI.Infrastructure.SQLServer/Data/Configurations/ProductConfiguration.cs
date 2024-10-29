using HomeDecorAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Reflection.Emit;

namespace HomeDecorAPI.Infrastructure.SQLServer.Data.Configurations {
    public class ProductConfiguration : IEntityTypeConfiguration<Product> {
        public void Configure(EntityTypeBuilder<Product> builder) {

            builder.HasMany(p => p.Categories)
                .WithMany(c => c.Products)
                .UsingEntity(j => j.ToTable("ProductCategory"));

            builder.HasOne(p => p.ProductDetails)
                 .WithOne(pd => pd.Product)
                 .HasForeignKey<ProductDetails>(pd => pd.ProductId);

            builder.HasMany(p => p.ProductVariants)
                 .WithOne(pv => pv.Product)
                 .HasForeignKey(pv => pv.ProductId);
            
        }
    }
}
