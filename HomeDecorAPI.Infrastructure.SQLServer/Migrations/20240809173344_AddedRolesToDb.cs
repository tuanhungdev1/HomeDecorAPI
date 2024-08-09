using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4282b80d-a9f7-4d6f-a77a-b0bdf3cf64fb", null, "Admin", "ADMIN" },
                    { "83acbc44-4d31-4468-81f3-68a328a4d11c", null, "Customer", "CUSTOMER" },
                    { "c9ac9e64-963d-4a3d-9298-ebafe3e7c6c5", null, "Vender", "Vender" },
                    { "f03116e0-d160-464e-93ff-60942655974e", null, "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4282b80d-a9f7-4d6f-a77a-b0bdf3cf64fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83acbc44-4d31-4468-81f3-68a328a4d11c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9ac9e64-963d-4a3d-9298-ebafe3e7c6c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f03116e0-d160-464e-93ff-60942655974e");
        }
    }
}
