using HomeDecorAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeDecorAPI.Infrastructure.SQLServer.Data.Configurations {
    public class CategoryConfiguration : IEntityTypeConfiguration<Category> {
        public void Configure(EntityTypeBuilder<Category> builder) {

            builder.HasOne(c => c.ParentCategory)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(c => c.ParentCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                ;

			builder.HasData(
				new Category { Id = 31, Name = "Living Room", Description = "Decor items for the living room.", IsActive = true, ParentCategoryId = null },
				new Category { Id = 32, Name = "Sofas & Couches", Description = "Comfortable seating options.", IsActive = true, ParentCategoryId = 31 },
				new Category { Id = 33, Name = "Coffee Tables", Description = "Stylish coffee tables.", IsActive = true, ParentCategoryId = 31 },
				new Category { Id = 34, Name = "Bedroom", Description = "Essentials for bedroom decor.", IsActive = true, ParentCategoryId = null },
				new Category { Id = 35, Name = "Bed Frames", Description = "Elegant bed frames for any style.", IsActive = true, ParentCategoryId = 34 },
				new Category { Id = 36, Name = "Nightstands", Description = "Compact nightstands for storage.", IsActive = true, ParentCategoryId = 34 },
				new Category { Id = 37, Name = "Kitchen", Description = "Decor and utilities for the kitchen.", IsActive = true, ParentCategoryId = null },
				new Category { Id = 38, Name = "Cookware", Description = "High-quality cookware sets.", IsActive = true, ParentCategoryId = 37 },
				new Category { Id = 39, Name = "Dining Sets", Description = "Elegant dining tables and chairs.", IsActive = true, ParentCategoryId = 37 },
				new Category { Id = 40, Name = "Bathroom", Description = "Stylish items for bathroom decor.", IsActive = true, ParentCategoryId = null },
				new Category { Id = 41, Name = "Bath Towels", Description = "Soft and absorbent towels.", IsActive = true, ParentCategoryId = 40 },
				new Category { Id = 42, Name = "Shower Curtains", Description = "Elegant shower curtains.", IsActive = true, ParentCategoryId = 40 },
				new Category { Id = 43, Name = "Outdoor", Description = "Outdoor furniture and decor.", IsActive = true, ParentCategoryId = null },
				new Category { Id = 44, Name = "Patio Sets", Description = "Stylish patio furniture sets.", IsActive = true, ParentCategoryId = 43 },
				new Category { Id = 45, Name = "Garden Decor", Description = "Decorative items for the garden.", IsActive = true, ParentCategoryId = 43 },
				new Category { Id = 46, Name = "Office", Description = "Furniture and decor for the office.", IsActive = true, ParentCategoryId = null },
				new Category { Id = 47, Name = "Desks", Description = "Sturdy and stylish office desks.", IsActive = true, ParentCategoryId = 46 },
				new Category { Id = 48, Name = "Office Chairs", Description = "Ergonomic chairs for comfort.", IsActive = true, ParentCategoryId = 46 },
				new Category { Id = 49, Name = "Kids Room", Description = "Decor for children's rooms.", IsActive = true, ParentCategoryId = null },
				new Category { Id = 50, Name = "Toy Storage", Description = "Organize toys in style.", IsActive = true, ParentCategoryId = 49 },
	
	new Category { Id = 51, Name = "Furniture", Description = "All types of home furniture.", IsActive = true, ParentCategoryId = null },
	new Category { Id = 52, Name = "Lighting", Description = "Indoor and outdoor lighting options.", IsActive = true, ParentCategoryId = null },

	
	new Category { Id = 53, Name = "Living Room Furniture", Description = "Furniture for living rooms.", IsActive = true, ParentCategoryId = 51 },
	new Category { Id = 54, Name = "Bedroom Furniture", Description = "Furniture for bedrooms.", IsActive = true, ParentCategoryId = 51 },
	new Category { Id = 55, Name = "Office Furniture", Description = "Furniture for home offices.", IsActive = true, ParentCategoryId = 51 },

	
	new Category { Id = 56, Name = "TV Stands", Description = "TV stands and media consoles.", IsActive = true, ParentCategoryId = 53 },
	new Category { Id = 57, Name = "Accent Chairs", Description = "Stylish accent chairs.", IsActive = true, ParentCategoryId = 53 },
	new Category { Id = 58, Name = "Bookshelves", Description = "Bookshelves and storage units.", IsActive = true, ParentCategoryId = 53 },

	
	new Category { Id = 59, Name = "Dressers", Description = "Dressers and storage units for bedrooms.", IsActive = true, ParentCategoryId = 54 },
	new Category { Id = 60, Name = "Wardrobes", Description = "Wardrobes for clothing storage.", IsActive = true, ParentCategoryId = 54 },
	new Category { Id = 61, Name = "Nightstands", Description = "Nightstands for bedside storage.", IsActive = true, ParentCategoryId = 54 },


	new Category { Id = 62, Name = "Office Desks", Description = "Desks for home offices.", IsActive = true, ParentCategoryId = 55 },
	new Category { Id = 63, Name = "Office Chairs", Description = "Chairs for home offices.", IsActive = true, ParentCategoryId = 55 },
	new Category { Id = 64, Name = "File Cabinets", Description = "File cabinets and organizers.", IsActive = true, ParentCategoryId = 55 },

	
	new Category { Id = 65, Name = "Ceiling Lights", Description = "Chandeliers, pendant lights, and more.", IsActive = true, ParentCategoryId = 52 },
	new Category { Id = 66, Name = "Wall Lights", Description = "Wall-mounted lighting options.", IsActive = true, ParentCategoryId = 52 },
	new Category { Id = 67, Name = "Table Lamps", Description = "Table lamps for every room.", IsActive = true, ParentCategoryId = 52 },

	
	new Category { Id = 68, Name = "Chandeliers", Description = "Elegant chandeliers.", IsActive = true, ParentCategoryId = 65 },
	new Category { Id = 69, Name = "Pendant Lights", Description = "Stylish pendant lighting.", IsActive = true, ParentCategoryId = 65 },

	
	new Category { Id = 70, Name = "Sconces", Description = "Decorative wall sconces.", IsActive = true, ParentCategoryId = 66 },
	new Category { Id = 71, Name = "Swing Arm Lamps", Description = "Adjustable wall lamps.", IsActive = true, ParentCategoryId = 66 },

	
	new Category { Id = 72, Name = "Desk Lamps", Description = "Compact desk lamps.", IsActive = true, ParentCategoryId = 67 },
	new Category { Id = 73, Name = "Bedside Lamps", Description = "Bedside lighting solutions.", IsActive = true, ParentCategoryId = 67 }
			);
		}
    }
}
