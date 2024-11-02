using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class Seenfakedataforsupplierandbrand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c93fc8e-1ac7-433c-97e9-4b3e7f126de7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbf9c425-ee35-4e0a-aa1b-24d43bb9e40b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c50fcd4-3d59-4df8-8f6c-a7ab151b1e70", null, "Admin", "ADMIN" },
                    { "c298106d-f7d0-4c91-ad70-1fdd5181349e", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "LogoUrl", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3388), "Comfortable and modern home decor", true, null, "CozyNest", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3389) },
                    { 2, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3393), "High-end decoration products for home", true, null, "Luxurious Living", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3394) },
                    { 3, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3395), "Natural and eco-friendly decor", true, null, "Nature Harmony", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3395) },
                    { 4, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3396), "Rustic-themed decor for cozy homes", false, null, "Rustic Charm", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3396) },
                    { 5, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3397), "Modern and sleek decor solutions", true, null, "Urban Modern", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3398) },
                    { 6, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3399), "Vintage-inspired decor pieces", true, null, "Vintage Vibes", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3399) },
                    { 7, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3400), "Minimalist, clutter-free designs", true, null, "Minimalist Space", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3400) },
                    { 8, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3401), "Scandinavian-style simplicity", true, null, "Scandinavian Simplicity", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3402) },
                    { 9, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3403), "Industrial-themed home decor", false, null, "Industrial Touch", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3403) },
                    { 10, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3404), "Classic style for a sophisticated look", true, null, "Classic Elegance", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3404) },
                    { 11, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3459), "Boho-inspired vibrant decor", true, null, "Bohemian Bliss", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3459) },
                    { 12, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3461), "Eco-friendly decor products", true, null, "Eco Essentials", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3461) },
                    { 13, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3462), "Handmade artisan decor", false, null, "Artisan Crafted", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3462) },
                    { 14, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3464), "Modern farmhouse style decor", true, null, "Modern Farmhouse", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3464) },
                    { 15, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3465), "Contemporary decor for urban homes", true, null, "Contemporary Chic", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3465) },
                    { 16, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3466), "Soft, vintage-style decor", false, null, "Shabby Chic", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3466) },
                    { 17, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3468), "Elegant essentials for the home", true, null, "Elegant Essentials", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3468) },
                    { 18, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3469), "Beach-inspired comfortable decor", true, null, "Coastal Comfort", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3469) },
                    { 19, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3470), "Urban loft-style decor pieces", true, null, "Urban Loft", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3471) },
                    { 20, new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3472), "Timeless, classic decor pieces", true, null, "Timeless Heritage", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3472) }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "City", "ContactPerson", "Country", "CreatedAt", "Description", "Email", "IsActive", "LogoUrl", "Name", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "123 Decor St", "New York", "John Doe", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2804), "Contemporary furniture and decor", "johndoe@moderndesigns.com", true, null, "Modern Designs", "1234567890", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2807) },
                    { 2, "456 Wood Ave", "Austin", "Jane Smith", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2814), "Natural, rustic home goods", "janesmith@rusticroots.com", true, null, "Rustic Roots", "0987654321", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2816) },
                    { 3, "789 Green Blvd", "San Francisco", "Emma Johnson", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2857), "Eco-friendly decor solutions", "emma@ecoessentials.com", true, null, "Eco Essentials", "5678901234", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2857) },
                    { 4, "101 Trendy St", "Los Angeles", "James Brown", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2859), "Trendy decor for modern spaces", "james@urbandecor.com", false, null, "Urban Decor Co.", "4561237890", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2859) },
                    { 5, "202 Classic Way", "Chicago", "Sophia Williams", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2861), "Classic and vintage decor items", "sophia@vintagedecor.com", true, null, "Vintage Decor", "8901234567", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2861) },
                    { 6, "303 Simplicity St", "Seattle", "Olivia Taylor", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2862), "Minimalist-inspired decor", "olivia@minimalisttouch.com", true, null, "Minimalist Touch", "3216549870", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2863) },
                    { 7, "404 Freedom Ln", "Denver", "Liam Martinez", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2864), "Bohemian-style decor", "liam@bohobliss.com", false, null, "Boho Bliss", "9876543210", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2865) },
                    { 8, "505 Craft Rd", "Portland", "Mason Anderson", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2866), "Handcrafted decor for home", "mason@artisanhome.com", true, null, "Artisan Home", "2345678901", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2866) },
                    { 9, "606 Tradition Blvd", "Nashville", "Ava Thomas", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2868), "Timeless and classic home decor", "ava@timelessdecor.com", true, null, "Timeless Decor", "7654321098", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2868) },
                    { 10, "707 World St", "Phoenix", "Ethan White", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2869), "Globally inspired decor pieces", "ethan@globalgoods.com", true, null, "Global Goods", "6547893210", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2869) },
                    { 11, "808 Nature Dr", "Miami", "Amelia Harris", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2871), "Nature-inspired home goods", "amelia@naturalelements.com", true, null, "Natural Elements", "1239874560", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2871) },
                    { 12, "909 Trendy Ave", "Houston", "Lucas Clark", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2872), "Modern, urban-style decor", "lucas@urbantrends.com", false, null, "Urban Trends", "7894561230", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2873) },
                    { 13, "1010 Cozy Ln", "Charlotte", "Charlotte Robinson", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2874), "Rustic and cozy home decor", "charlotte@countrycottage.com", true, null, "Country Cottage", "4567890123", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2874) },
                    { 14, "1111 Shore St", "San Diego", "Jackson Lewis", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2876), "Beach-inspired decor items", "jackson@coastalliving.com", true, null, "Coastal Living", "0987123456", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2876) },
                    { 15, "1212 Farmhouse Ave", "Dallas", "Harper Lee", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2877), "Farmhouse-style decor for modern homes", "harper@modernfarmhouse.com", true, null, "Modern Farmhouse", "2345678909", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2878) },
                    { 16, "1313 Nordic Rd", "Boston", "Sebastian Wilson", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2879), "Scandinavian-inspired decor", "sebastian@scandihome.com", false, null, "Scandi Home", "6789012345", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2879) },
                    { 17, "1414 Glam Blvd", "Las Vegas", "Isabella King", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2881), "Luxury decor for upscale homes", "isabella@luxuryinteriors.com", true, null, "Luxury Interiors", "5432109876", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2881) },
                    { 18, "1515 Earth St", "Orlando", "Henry Scott", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2882), "Eco-conscious home decor solutions", "henry@ecohomedecor.com", true, null, "Eco Home Decor", "3456789012", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2883) },
                    { 19, "1616 Timeless Blvd", "Atlanta", "Grace Adams", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2884), "Elegant decor for classic homes", "grace@classicelegance.com", true, null, "Classic Elegance", "2109876543", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2884) },
                    { 20, "1717 Art St", "Los Angeles", "Sophia Young", "USA", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2886), "Art-inspired decor", "sophia@artisticspaces.com", true, null, "Artistic Spaces", "6785432109", new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2886) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c50fcd4-3d59-4df8-8f6c-a7ab151b1e70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c298106d-f7d0-4c91-ad70-1fdd5181349e");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5c93fc8e-1ac7-433c-97e9-4b3e7f126de7", null, "Customer", "CUSTOMER" },
                    { "fbf9c425-ee35-4e0a-aa1b-24d43bb9e40b", null, "Admin", "ADMIN" }
                });
        }
    }
}
