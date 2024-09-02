using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class Defaultrolesforapplicationmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26188004-1eae-4c3d-bbe0-471366ef48fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c51448d-98c6-464b-9899-8a4c017bc213");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "670aebbc-1700-4642-ba0c-249ca770ddbd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d90e0edc-2d45-44b1-a5fc-22e021dc1d17");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4c2d3c00-6f4c-40f4-a140-35e9c348dd6c", null, "Manager", "MANAGER" },
                    { "54145f54-0e28-48a4-a8ec-370ba8e1fb00", null, "Moderator", "MODERATOR" },
                    { "99c9d328-0436-402f-9d50-c4cb8c336adc", null, "Customer", "CUSTOMER" },
                    { "b8fc6920-3f96-4eb0-a814-95dd2049eeb0", null, "ContentCreator", "CONTENTCREATOR" },
                    { "e4659fb8-10e6-44fc-b58a-0cf82a5b5cae", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 9, 2, 21, 19, 1, 700, DateTimeKind.Utc).AddTicks(1954), new DateTime(2024, 10, 2, 21, 19, 1, 700, DateTimeKind.Utc).AddTicks(1944), new DateTime(2024, 9, 16, 21, 19, 1, 700, DateTimeKind.Utc).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 21, 19, 1, 700, DateTimeKind.Utc).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 9, 2, 21, 19, 1, 700, DateTimeKind.Utc).AddTicks(1965), new DateTime(2024, 10, 17, 21, 19, 1, 700, DateTimeKind.Utc).AddTicks(1963), new DateTime(2024, 9, 16, 21, 19, 1, 700, DateTimeKind.Utc).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DiscountEndDate" },
                values: new object[] { new DateTime(2024, 9, 2, 21, 19, 1, 700, DateTimeKind.Utc).AddTicks(1971), new DateTime(2024, 9, 17, 21, 19, 1, 700, DateTimeKind.Utc).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 9, 2, 21, 19, 1, 700, DateTimeKind.Utc).AddTicks(1976), new DateTime(2024, 11, 1, 21, 19, 1, 700, DateTimeKind.Utc).AddTicks(1974), new DateTime(2024, 9, 16, 21, 19, 1, 700, DateTimeKind.Utc).AddTicks(1975) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c2d3c00-6f4c-40f4-a140-35e9c348dd6c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54145f54-0e28-48a4-a8ec-370ba8e1fb00");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99c9d328-0436-402f-9d50-c4cb8c336adc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8fc6920-3f96-4eb0-a814-95dd2049eeb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4659fb8-10e6-44fc-b58a-0cf82a5b5cae");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26188004-1eae-4c3d-bbe0-471366ef48fa", null, "ContentCreator", "ContentCreator" },
                    { "4c51448d-98c6-464b-9899-8a4c017bc213", null, "Manager", "MANAGER" },
                    { "670aebbc-1700-4642-ba0c-249ca770ddbd", null, "Customer", "CUSTOMER" },
                    { "d90e0edc-2d45-44b1-a5fc-22e021dc1d17", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 9, 2, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(868), new DateTime(2024, 10, 2, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(860), new DateTime(2024, 9, 16, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 9, 2, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(875), new DateTime(2024, 10, 17, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(873), new DateTime(2024, 9, 16, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DiscountEndDate" },
                values: new object[] { new DateTime(2024, 9, 2, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(878), new DateTime(2024, 9, 17, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 9, 2, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(882), new DateTime(2024, 11, 1, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(880), new DateTime(2024, 9, 16, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(881) });
        }
    }
}
