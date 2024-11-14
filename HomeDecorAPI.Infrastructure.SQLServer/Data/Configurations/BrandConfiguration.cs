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
                new Brand { Id = 20, Name = "Timeless Heritage", Description = "Timeless, classic decor pieces", IsActive = true },
				new Brand { Id = 21, Name = "Green Haven", Description = "Eco-conscious decor for sustainable homes", IsActive = true },
	new Brand { Id = 22, Name = "Elegant Earth", Description = "Earth-toned and natural decor items", IsActive = true },
	new Brand { Id = 23, Name = "Zen Home", Description = "Relaxing and peaceful home decor", IsActive = true },
	new Brand { Id = 24, Name = "Sophisticated Spaces", Description = "Sophisticated, high-quality decor", IsActive = true },
	new Brand { Id = 25, Name = "Urban Jungle", Description = "Decor inspired by nature and urban life", IsActive = true },
	new Brand { Id = 26, Name = "Cosmopolitan Living", Description = "Global-inspired modern decor", IsActive = true },
	new Brand { Id = 27, Name = "Luxe Retreat", Description = "Luxurious decor for a refined look", IsActive = false },
	new Brand { Id = 28, Name = "Eco Elements", Description = "Sustainable decor with natural elements", IsActive = true },
	new Brand { Id = 29, Name = "Global Fusion", Description = "Fusion of global decor styles", IsActive = true },
	new Brand { Id = 30, Name = "Majestic Manor", Description = "Classic decor for a grand home", IsActive = false },
	new Brand { Id = 31, Name = "Bespoke Living", Description = "Customized and bespoke decor", IsActive = true },
	new Brand { Id = 32, Name = "Timeless Serenity", Description = "Calm and serene decor themes", IsActive = true },
	new Brand { Id = 33, Name = "Hygge Home", Description = "Cozy decor inspired by the Hygge lifestyle", IsActive = true },
	new Brand { Id = 34, Name = "Retro Revival", Description = "Retro-style decor pieces", IsActive = true },
	new Brand { Id = 35, Name = "Eco Chic", Description = "Eco-friendly chic decor solutions", IsActive = true },
	new Brand { Id = 36, Name = "Art Deco Dream", Description = "Art Deco-inspired decor items", IsActive = false },
	new Brand { Id = 37, Name = "Vintage Industrial", Description = "Industrial with a vintage touch", IsActive = true },
	new Brand { Id = 38, Name = "Mediterranean Magic", Description = "Mediterranean-inspired decor", IsActive = true },
	new Brand { Id = 39, Name = "Urban Nature", Description = "Urban decor with a natural feel", IsActive = true },
	new Brand { Id = 40, Name = "Classic Crafts", Description = "Handcrafted decor with classic designs", IsActive = true },
	new Brand { Id = 41, Name = "Rustic Roots", Description = "Earthy, rustic decor for cozy homes", IsActive = true },
	new Brand { Id = 42, Name = "Artisan Atelier", Description = "Handcrafted decor inspired by local artisans", IsActive = false },
	new Brand { Id = 43, Name = "Harmony Home", Description = "Balanced and calming decor styles", IsActive = true },
	new Brand { Id = 44, Name = "Opulent Oasis", Description = "Luxurious decor with an opulent touch", IsActive = true },
	new Brand { Id = 45, Name = "Elegant Essence", Description = "Timeless, elegant decor essentials", IsActive = true },
	new Brand { Id = 46, Name = "Desert Dream", Description = "Decor inspired by desert landscapes", IsActive = false },
	new Brand { Id = 47, Name = "Pacific Coast", Description = "Coastal-themed decor inspired by the ocean", IsActive = true },
	new Brand { Id = 48, Name = "Modern Vintage", Description = "Modern decor with vintage charm", IsActive = true },
	new Brand { Id = 49, Name = "Cottage Comfort", Description = "Cozy decor inspired by cottage living", IsActive = true },
	new Brand { Id = 50, Name = "Tropical Touch", Description = "Tropical decor for a refreshing vibe", IsActive = true },
	new Brand { Id = 51, Name = "Contemporary Comfort", Description = "Contemporary decor with a warm touch", IsActive = true },
	new Brand { Id = 52, Name = "Industrial Chic", Description = "Chic decor with industrial influences", IsActive = false },
	new Brand { Id = 53, Name = "Global Treasures", Description = "Decor inspired by global cultures", IsActive = true },
	new Brand { Id = 54, Name = "Nautical Haven", Description = "Decor with nautical and seaside elements", IsActive = true },
	new Brand { Id = 55, Name = "Royal Residences", Description = "Regal decor fit for royalty", IsActive = true },
	new Brand { Id = 56, Name = "Minimal Marvel", Description = "Minimalist decor with a modern twist", IsActive = true },
	new Brand { Id = 57, Name = "Countryside Charm", Description = "Decor inspired by countryside aesthetics", IsActive = true },
	new Brand { Id = 58, Name = "Boho Retreat", Description = "Bohemian decor for free spirits", IsActive = true },
	new Brand { Id = 59, Name = "Modern Organics", Description = "Modern decor with organic materials", IsActive = true },
	new Brand { Id = 60, Name = "Lavish Living", Description = "Lavish decor for luxury homes", IsActive = true }
			);
        }
    }
}
