using HomeDecorAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace HomeDecorAPI.Infrastructure.SQLServer.Data.Configurations {
    public class ProductConfiguration : IEntityTypeConfiguration<Product> {
        public void Configure(EntityTypeBuilder<Product> builder) {
            builder.HasData(
                new Product {
                    Id = 1,
                    Name = "Modern Wooden Coffee Table",
                    Description = "A sleek and modern coffee table made from high-quality oak wood.",
                    OriginalPrice = 149.99m,
                    DiscountPercentage = 10,
                    DiscountEndDate = DateTime.UtcNow.AddDays(30), // Giảm giá hết hạn sau 30 ngày
                    ImageUrl = "https://th.bing.com/th/id/OIP.j8duPDpTdbCRp96Z-V6jXQHaHa?rs=1&pid=ImgDetMain",
                    
                    IsNewExpiryDate = DateTime.UtcNow.AddDays(14), // Sản phẩm mới trong 14 ngày
                    SKU = "WDN-COFTBL-001",
                    Measurements = "120x60x45 cm",
                    StockQuantity = 50,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                },
                new Product {
                    Id = 2,
                    Name = "Classic Leather Armchair",
                    Description = "A comfortable and stylish armchair upholstered in genuine leather.",
                    OriginalPrice = 299.99m,
                    DiscountPercentage = null,
                    DiscountEndDate = null, // Không có giảm giá
                    ImageUrl = "https://a.1stdibscdn.com/20th-century-french-leather-wing-back-armchair-c1960-for-sale-picture-2/f_13482/f_285265221651735694424/PUSHKIN_ANTIQUES_STUNNING_LATE_20thC_FRENCH_LEATHER_WING_BACK_ARMCHAIR_c_1960_03_master.jpg?width=768",
                    
                    IsNewExpiryDate = null, // Không còn là sản phẩm mới
                    SKU = "LTHR-ARMCHR-002",
                    Measurements = "90x80x75 cm",
                    StockQuantity = 20,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new Product {
                    Id = 3,
                    Name = "Contemporary Floor Lamp",
                    Description = "A minimalist floor lamp with a sleek metal frame and adjustable height.",
                    OriginalPrice = 89.99m,
                    DiscountPercentage = 15,
                    DiscountEndDate = DateTime.UtcNow.AddDays(45), // Giảm giá hết hạn sau 45 ngày
                    ImageUrl = "https://i5.walmartimages.com/asr/3181df7b-b2e3-411e-bf47-95fe5bcd8c4b_1.c7553cfd9e1daaed9c6cd9e1544bb12b.jpeg",
                    
                    IsNewExpiryDate = DateTime.UtcNow.AddDays(14), // Sản phẩm mới trong 14 ngày
                    SKU = "MTL-FLRLMP-003",
                    Measurements = "Height: 150-180 cm",
                    StockQuantity = 100,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                },
                new Product {
                    Id = 4,
                    Name = "Vintage Wall Clock",
                    Description = "A beautiful vintage wall clock with a wooden frame and Roman numerals.",
                    OriginalPrice = 59.99m,
                    DiscountPercentage = 5,
                    DiscountEndDate = DateTime.UtcNow.AddDays(15), // Giảm giá hết hạn sau 15 ngày
                    ImageUrl = "https://www.vkwoods.com/vkwoods/uploads/2022/03/TJP_7853_1024x1024.webp",
                    
                    IsNewExpiryDate = null, // Không còn là sản phẩm mới
                    SKU = "VTG-WLCLK-004",
                    Measurements = "Diameter: 40 cm",
                    StockQuantity = 75,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                },
                new Product {
                    Id = 5,
                    Name = "Marble Dining Table",
                    Description = "A luxurious dining table with a polished marble top and sturdy metal legs.",
                    OriginalPrice = 799.99m,
                    DiscountPercentage = 20,
                    DiscountEndDate = DateTime.UtcNow.AddDays(60), // Giảm giá hết hạn sau 60 ngày
                    ImageUrl = "https://th.bing.com/th/id/R.8c5920f9aeefc029e47eb83afb6f5283?rik=ACMUfp1vINNgnQ&pid=ImgRaw&r=0",
                    
                    IsNewExpiryDate = DateTime.UtcNow.AddDays(14), // Sản phẩm mới trong 14 ngày
                    SKU = "MRB-DNTBL-005",
                    Measurements = "200x100x75 cm",
                    StockQuantity = 10,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                }
            );
        }
    }
}
