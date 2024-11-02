using HomeDecorAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeDecorAPI.Infrastructure.SQLServer.Data.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasMany(s => s.Products)
                 .WithOne(p => p.Brand)
                 .HasForeignKey(p => p.BrandId);

            // Cập nhật thêm Id cho dữ liệu mẫu
            builder.HasData(
                new Brand { Id = 1, Name = "CozyNest", Description = "Comfortable and modern home decor", IsActive = true },
                new Brand { Id = 2, Name = "Luxurious Living", Description = "High-end decoration products for home", IsActive = true },
                new Brand { Id = 3, Name = "Nature Harmony", Description = "Natural and eco-friendly decor", IsActive = true },
                new Brand { Id = 4, Name = "Rustic Charm", Description = "Rustic-themed decor for cozy homes", IsActive = false },
                new Brand { Id = 5, Name = "Urban Modern", Description = "Modern and sleek decor solutions", IsActive = true },
                new Brand { Id = 6, Name = "Vintage Vibes", Description = "Vintage-inspired decor pieces", IsActive = true },
                new Brand { Id = 7, Name = "Minimalist Space", Description = "Minimalist, clutter-free designs", IsActive = true },
                new Brand { Id = 8, Name = "Scandinavian Simplicity", Description = "Scandinavian-style simplicity", IsActive = true },
                new Brand { Id = 9, Name = "Industrial Touch", Description = "Industrial-themed home decor", IsActive = false },
                new Brand { Id = 10, Name = "Classic Elegance", Description = "Classic style for a sophisticated look", IsActive = true },
                new Brand { Id = 11, Name = "Bohemian Bliss", Description = "Boho-inspired vibrant decor", IsActive = true },
                new Brand { Id = 12, Name = "Eco Essentials", Description = "Eco-friendly decor products", IsActive = true },
                new Brand { Id = 13, Name = "Artisan Crafted", Description = "Handmade artisan decor", IsActive = false },
                new Brand { Id = 14, Name = "Modern Farmhouse", Description = "Modern farmhouse style decor", IsActive = true },
                new Brand { Id = 15, Name = "Contemporary Chic", Description = "Contemporary decor for urban homes", IsActive = true },
                new Brand { Id = 16, Name = "Shabby Chic", Description = "Soft, vintage-style decor", IsActive = false },
                new Brand { Id = 17, Name = "Elegant Essentials", Description = "Elegant essentials for the home", IsActive = true },
                new Brand { Id = 18, Name = "Coastal Comfort", Description = "Beach-inspired comfortable decor", IsActive = true },
                new Brand { Id = 19, Name = "Urban Loft", Description = "Urban loft-style decor pieces", IsActive = true },
                new Brand { Id = 20, Name = "Timeless Heritage", Description = "Timeless, classic decor pieces", IsActive = true }
            );
        }
    }
}
