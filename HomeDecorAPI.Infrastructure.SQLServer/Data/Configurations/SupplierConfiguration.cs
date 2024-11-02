using HomeDecorAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeDecorAPI.Infrastructure.SQLServer.Data.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasMany(s => s.Products)
                 .WithOne(p => p.Supplier)
                 .HasForeignKey(p => p.SupplierId);

            // Seed fake data for Supplier
            builder.HasData(
                new Supplier {Id = 1, Name = "Modern Designs", Description = "Contemporary furniture and decor", ContactPerson = "John Doe", Email = "johndoe@moderndesigns.com", Phone = "1234567890", City = "New York", Address = "123 Decor St", Country = "USA", IsActive = true },
                new Supplier { Id = 2, Name = "Rustic Roots", Description = "Natural, rustic home goods", ContactPerson = "Jane Smith", Email = "janesmith@rusticroots.com", Phone = "0987654321", City = "Austin", Address = "456 Wood Ave", Country = "USA", IsActive = true },
                new Supplier { Id = 3, Name = "Eco Essentials", Description = "Eco-friendly decor solutions", ContactPerson = "Emma Johnson", Email = "emma@ecoessentials.com", Phone = "5678901234", City = "San Francisco", Address = "789 Green Blvd", Country = "USA", IsActive = true },
                new Supplier { Id = 4, Name = "Urban Decor Co.", Description = "Trendy decor for modern spaces", ContactPerson = "James Brown", Email = "james@urbandecor.com", Phone = "4561237890", City = "Los Angeles", Address = "101 Trendy St", Country = "USA", IsActive = false },
                new Supplier { Id = 5, Name = "Vintage Decor", Description = "Classic and vintage decor items", ContactPerson = "Sophia Williams", Email = "sophia@vintagedecor.com", Phone = "8901234567", City = "Chicago", Address = "202 Classic Way", Country = "USA", IsActive = true },
                new Supplier { Id = 6, Name = "Minimalist Touch", Description = "Minimalist-inspired decor", ContactPerson = "Olivia Taylor", Email = "olivia@minimalisttouch.com", Phone = "3216549870", City = "Seattle", Address = "303 Simplicity St", Country = "USA", IsActive = true },
                new Supplier { Id = 7, Name = "Boho Bliss", Description = "Bohemian-style decor", ContactPerson = "Liam Martinez", Email = "liam@bohobliss.com", Phone = "9876543210", City = "Denver", Address = "404 Freedom Ln", Country = "USA", IsActive = false },
                new Supplier { Id = 8, Name = "Artisan Home", Description = "Handcrafted decor for home", ContactPerson = "Mason Anderson", Email = "mason@artisanhome.com", Phone = "2345678901", City = "Portland", Address = "505 Craft Rd", Country = "USA", IsActive = true },
                new Supplier { Id = 9, Name = "Timeless Decor", Description = "Timeless and classic home decor", ContactPerson = "Ava Thomas", Email = "ava@timelessdecor.com", Phone = "7654321098", City = "Nashville", Address = "606 Tradition Blvd", Country = "USA", IsActive = true },
                new Supplier { Id = 10, Name = "Global Goods", Description = "Globally inspired decor pieces", ContactPerson = "Ethan White", Email = "ethan@globalgoods.com", Phone = "6547893210", City = "Phoenix", Address = "707 World St", Country = "USA", IsActive = true },
                new Supplier { Id = 11, Name = "Natural Elements", Description = "Nature-inspired home goods", ContactPerson = "Amelia Harris", Email = "amelia@naturalelements.com", Phone = "1239874560", City = "Miami", Address = "808 Nature Dr", Country = "USA", IsActive = true },
                new Supplier { Id = 12, Name = "Urban Trends", Description = "Modern, urban-style decor", ContactPerson = "Lucas Clark", Email = "lucas@urbantrends.com", Phone = "7894561230", City = "Houston", Address = "909 Trendy Ave", Country = "USA", IsActive = false },
                new Supplier { Id = 13, Name = "Country Cottage", Description = "Rustic and cozy home decor", ContactPerson = "Charlotte Robinson", Email = "charlotte@countrycottage.com", Phone = "4567890123", City = "Charlotte", Address = "1010 Cozy Ln", Country = "USA", IsActive = true },
                new Supplier { Id = 14, Name = "Coastal Living", Description = "Beach-inspired decor items", ContactPerson = "Jackson Lewis", Email = "jackson@coastalliving.com", Phone = "0987123456", City = "San Diego", Address = "1111 Shore St", Country = "USA", IsActive = true },
                new Supplier { Id = 15, Name = "Modern Farmhouse", Description = "Farmhouse-style decor for modern homes", ContactPerson = "Harper Lee", Email = "harper@modernfarmhouse.com", Phone = "2345678909", City = "Dallas", Address = "1212 Farmhouse Ave", Country = "USA", IsActive = true },
                new Supplier { Id = 16, Name = "Scandi Home", Description = "Scandinavian-inspired decor", ContactPerson = "Sebastian Wilson", Email = "sebastian@scandihome.com", Phone = "6789012345", City = "Boston", Address = "1313 Nordic Rd", Country = "USA", IsActive = false },
                new Supplier { Id = 17, Name = "Luxury Interiors", Description = "Luxury decor for upscale homes", ContactPerson = "Isabella King", Email = "isabella@luxuryinteriors.com", Phone = "5432109876", City = "Las Vegas", Address = "1414 Glam Blvd", Country = "USA", IsActive = true },
                new Supplier { Id = 18, Name = "Eco Home Decor", Description = "Eco-conscious home decor solutions", ContactPerson = "Henry Scott", Email = "henry@ecohomedecor.com", Phone = "3456789012", City = "Orlando", Address = "1515 Earth St", Country = "USA", IsActive = true },
                new Supplier { Id = 19, Name = "Classic Elegance", Description = "Elegant decor for classic homes", ContactPerson = "Grace Adams", Email = "grace@classicelegance.com", Phone = "2109876543", City = "Atlanta", Address = "1616 Timeless Blvd", Country = "USA", IsActive = true },
                new Supplier { Id = 20, Name = "Artistic Spaces", Description = "Art-inspired decor", ContactPerson = "Sophia Young", Email = "sophia@artisticspaces.com", Phone = "6785432109", City = "Los Angeles", Address = "1717 Art St", Country = "USA", IsActive = true }
            );
        }
    }
}
