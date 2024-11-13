using HomeDecorAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Infrastructure.SQLServer.Data.Configurations {
    public class WishlistItemConfiguration : IEntityTypeConfiguration<WishlistItem> {
        public void Configure(EntityTypeBuilder<WishlistItem> builder) { 
            builder.HasKey(wli => new {wli.WishlistId, wli.ProductVariantId});

            builder.HasOne(wli => wli.Wishlish)
                .WithMany(wl => wl.WishlistItems)
                .HasForeignKey(wl => wl.WishlistId);

            builder.HasOne(wli => wli.ProductVariant)
                .WithMany()
                .HasForeignKey(wli => wli.ProductVariantId);
        }
    }
}
