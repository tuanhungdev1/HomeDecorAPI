using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class fixtableproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44151e46-550b-494f-9a1e-9285dc762b85");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9de8a89b-26be-49b8-adf9-ca8567582895");

            migrationBuilder.DropColumn(
                name: "DiscountPrice",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "IsNew",
                table: "ProductVariants");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5c93fc8e-1ac7-433c-97e9-4b3e7f126de7", null, "Customer", "CUSTOMER" },
                    { "fbf9c425-ee35-4e0a-aa1b-24d43bb9e40b", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c93fc8e-1ac7-433c-97e9-4b3e7f126de7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbf9c425-ee35-4e0a-aa1b-24d43bb9e40b");

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountPrice",
                table: "ProductVariants",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsNew",
                table: "ProductVariants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "44151e46-550b-494f-9a1e-9285dc762b85", null, "Customer", "CUSTOMER" },
                    { "9de8a89b-26be-49b8-adf9-ca8567582895", null, "Admin", "ADMIN" }
                });
        }
    }
}
