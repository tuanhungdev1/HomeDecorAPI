using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class addproducttablemigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10a1d1fd-6a59-466f-9178-1bd5fed2af31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fce424c-efd7-4d91-8bba-b595c9163420");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22a22aef-6f93-4c69-a48a-5ec6931be98e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddd7b8ed-7264-4888-b8f9-d488d6d81db7");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPercentage = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNew = table.Column<bool>(type: "bit", nullable: true),
                    SKU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Measurements = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1495d67c-1b7f-46bf-a65c-224ee40e058b", null, "Customer", "CUSTOMER" },
                    { "2afd0b80-86a1-4c01-9e34-40b7257848aa", null, "ContentCreator", "ContentCreator" },
                    { "8f666d2d-fc40-4d9c-aa76-deb1e03ac9f0", null, "Manager", "MANAGER" },
                    { "df78c351-452a-4531-a371-baf0db0af7d3", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "Description", "DiscountPercentage", "ImageUrl", "IsNew", "Measurements", "Name", "OriginalPrice", "SKU", "StockQuantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 28, 14, 40, 53, 592, DateTimeKind.Utc).AddTicks(4825), "A sleek and modern coffee table made from high-quality oak wood.", 10, "https://th.bing.com/th/id/OIP.j8duPDpTdbCRp96Z-V6jXQHaHa?rs=1&pid=ImgDetMain", true, "120x60x45 cm", "Modern Wooden Coffee Table", 149.99m, "WDN-COFTBL-001", 50 },
                    { 2, new DateTime(2024, 8, 28, 14, 40, 53, 592, DateTimeKind.Utc).AddTicks(4827), "A comfortable and stylish armchair upholstered in genuine leather.", null, "https://a.1stdibscdn.com/20th-century-french-leather-wing-back-armchair-c1960-for-sale-picture-2/f_13482/f_285265221651735694424/PUSHKIN_ANTIQUES_STUNNING_LATE_20thC_FRENCH_LEATHER_WING_BACK_ARMCHAIR_c_1960_03_master.jpg?width=768", false, "90x80x75 cm", "Classic Leather Armchair", 299.99m, "LTHR-ARMCHR-002", 20 },
                    { 3, new DateTime(2024, 8, 28, 14, 40, 53, 592, DateTimeKind.Utc).AddTicks(4830), "A minimalist floor lamp with a sleek metal frame and adjustable height.", 15, "https://i5.walmartimages.com/asr/3181df7b-b2e3-411e-bf47-95fe5bcd8c4b_1.c7553cfd9e1daaed9c6cd9e1544bb12b.jpeg", true, "Height: 150-180 cm", "Contemporary Floor Lamp", 89.99m, "MTL-FLRLMP-003", 100 },
                    { 4, new DateTime(2024, 8, 28, 14, 40, 53, 592, DateTimeKind.Utc).AddTicks(4832), "A beautiful vintage wall clock with a wooden frame and Roman numerals.", 5, "https://www.vkwoods.com/vkwoods/uploads/2022/03/TJP_7853_1024x1024.webp", false, "Diameter: 40 cm", "Vintage Wall Clock", 59.99m, "VTG-WLCLK-004", 75 },
                    { 5, new DateTime(2024, 8, 28, 14, 40, 53, 592, DateTimeKind.Utc).AddTicks(4834), "A luxurious dining table with a polished marble top and sturdy metal legs.", 20, "https://th.bing.com/th/id/R.8c5920f9aeefc029e47eb83afb6f5283?rik=ACMUfp1vINNgnQ&pid=ImgRaw&r=0", true, "200x100x75 cm", "Marble Dining Table", 799.99m, "MRB-DNTBL-005", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1495d67c-1b7f-46bf-a65c-224ee40e058b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2afd0b80-86a1-4c01-9e34-40b7257848aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f666d2d-fc40-4d9c-aa76-deb1e03ac9f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df78c351-452a-4531-a371-baf0db0af7d3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10a1d1fd-6a59-466f-9178-1bd5fed2af31", null, "Manager", "MANAGER" },
                    { "1fce424c-efd7-4d91-8bba-b595c9163420", null, "Vender", "Vender" },
                    { "22a22aef-6f93-4c69-a48a-5ec6931be98e", null, "Customer", "CUSTOMER" },
                    { "ddd7b8ed-7264-4888-b8f9-d488d6d81db7", null, "Admin", "ADMIN" }
                });
        }
    }
}
