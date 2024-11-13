using HomeDecorAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Reflection.Emit;

namespace HomeDecorAPI.Infrastructure.SQLServer.Data.Configurations {
    public class ProductConfiguration : IEntityTypeConfiguration<Product> {
        public void Configure(EntityTypeBuilder<Product> builder) {

            builder.HasOne(p => p.Categories)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            builder.HasOne(p => p.ProductDetails)
                 .WithOne(pd => pd.Product)
                    .HasForeignKey<ProductDetails>(p => p.ProductId);

            builder.HasMany(p => p.ProductVariants)
                 .WithOne(pv => pv.Product)
                 .HasForeignKey(pv => pv.ProductId);

            builder.HasOne(p => p.Categories)
               .WithMany(c => c.Products)
               .HasForeignKey(p => p.CategoryId);

            builder.HasOne(p => p.Supplier)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.SupplierId);

            builder.HasOne(p => p.Brand)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.BrandId);

			builder.HasMany(p => p.Reviews)
			    .WithOne(r => r.Product)
			    .HasForeignKey(r => r.ProductId)
			    .OnDelete(DeleteBehavior.Cascade);

            
		}
    }
}
