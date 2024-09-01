using HomeDecorAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeDecorAPI.Infrastructure.SQLServer.Data.Configurations {
    public class CategoryConfiguration : IEntityTypeConfiguration<Category> {
        public void Configure(EntityTypeBuilder<Category> builder) {

            

            builder.HasData(
                new Category {
                    Id = 1,
                    Name = "Bedroom",
                    Description = "All bedroom related furniture and accessories",
                    ImageUrl = "https://example.com/bedroom.jpg"
                },
                new Category {
                    Id = 2,
                    Name = "Beds",
                    Description = "Different types of beds",
                    ImageUrl = "https://example.com/beds.jpg",
                    ParentCategoryId = 1
                },
                new Category {
                    Id = 3,
                    Name = "Lamps",
                    Description = "Various bedroom lamps",
                    ImageUrl = "https://example.com/lamps.jpg",
                    ParentCategoryId = 1
                },
                new Category {
                    Id = 4,
                    Name = "Wardrobes",
                    Description = "Wardrobes and storage solutions",
                    ImageUrl = "https://example.com/wardrobes.jpg",
                    ParentCategoryId = 1
                },
                new Category {
                    Id = 5,
                    Name = "Dressers",
                    Description = "Dressers and bedroom storage",
                    ImageUrl = "https://example.com/dressers.jpg",
                    ParentCategoryId = 1
                },
                new Category {
                    Id = 6,
                    Name = "Living Room",
                    Description = "Furniture and accessories for the living room",
                    ImageUrl = "https://example.com/livingroom.jpg"
                },
                new Category {
                    Id = 7,
                    Name = "Sofas",
                    Description = "Various types of sofas for the living room",
                    ImageUrl = "https://example.com/sofas.jpg",
                    ParentCategoryId = 6
                },
                new Category {
                    Id = 8,
                    Name = "Coffee Tables",
                    Description = "Coffee tables for the living room",
                    ImageUrl = "https://example.com/coffeetables.jpg",
                    ParentCategoryId = 6
                },
                new Category {
                    Id = 9,
                    Name = "TV Stands",
                    Description = "TV stands and media units",
                    ImageUrl = "https://example.com/tvstands.jpg",
                    ParentCategoryId = 6
                },
                new Category {
                    Id = 10,
                    Name = "Bookcases",
                    Description = "Bookcases and shelving units",
                    ImageUrl = "https://example.com/bookcases.jpg",
                    ParentCategoryId = 6
                },
                new Category {
                    Id = 11,
                    Name = "Dining Room",
                    Description = "Furniture and accessories for the dining room",
                    ImageUrl = "https://example.com/diningroom.jpg"
                },
                new Category {
                    Id = 12,
                    Name = "Dining Tables",
                    Description = "Dining tables for the dining room",
                    ImageUrl = "https://example.com/diningtables.jpg",
                    ParentCategoryId = 11
                },
                new Category {
                    Id = 13,
                    Name = "Dining Chairs",
                    Description = "Dining chairs for the dining room",
                    ImageUrl = "https://example.com/diningchairs.jpg",
                    ParentCategoryId = 11
                },
                new Category {
                    Id = 14,
                    Name = "Bar Stools",
                    Description = "Bar stools and counter seating",
                    ImageUrl = "https://example.com/barstools.jpg",
                    ParentCategoryId = 11
                },
                new Category {
                    Id = 15,
                    Name = "Kitchen",
                    Description = "Furniture and accessories for the kitchen",
                    ImageUrl = "https://example.com/kitchen.jpg"
                },
                new Category {
                    Id = 16,
                    Name = "Cabinets",
                    Description = "Kitchen cabinets and storage solutions",
                    ImageUrl = "https://example.com/cabinets.jpg",
                    ParentCategoryId = 15
                },
                new Category {
                    Id = 17,
                    Name = "Kitchen Islands",
                    Description = "Kitchen islands and counters",
                    ImageUrl = "https://example.com/kitchenislands.jpg",
                    ParentCategoryId = 15
                },
                new Category {
                    Id = 18,
                    Name = "Outdoor",
                    Description = "Furniture and accessories for outdoor spaces",
                    ImageUrl = "https://example.com/outdoor.jpg"
                },
                new Category {
                    Id = 19,
                    Name = "Outdoor Seating",
                    Description = "Seating solutions for outdoor areas",
                    ImageUrl = "https://example.com/outdoorseating.jpg",
                    ParentCategoryId = 18
                },
                new Category {
                    Id = 20,
                    Name = "Outdoor Tables",
                    Description = "Tables for outdoor dining and lounging",
                    ImageUrl = "https://example.com/outdoortables.jpg",
                    ParentCategoryId = 18
                }
            );
        }
    }
}
