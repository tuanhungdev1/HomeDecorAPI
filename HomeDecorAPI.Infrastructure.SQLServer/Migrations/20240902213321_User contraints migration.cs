using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class Usercontraintsmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a548cac-eff6-412c-8dc5-0198c24a66ed", null, "Admin", "ADMIN" },
                    { "455054fd-dbf3-455c-8bd6-74b89743a58a", null, "Manager", "MANAGER" },
                    { "90bb9065-7ac9-446a-b073-23c4b84005e8", null, "Customer", "CUSTOMER" },
                    { "e04294e6-62a1-40fd-853b-36a43acb89ea", null, "ContentCreator", "CONTENTCREATOR" },
                    { "fcc7aac0-c111-4d2a-bc5f-68b739438d85", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 9, 2, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6914), new DateTime(2024, 10, 2, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6882), new DateTime(2024, 9, 16, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 9, 2, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6923), new DateTime(2024, 10, 17, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6921), new DateTime(2024, 9, 16, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DiscountEndDate" },
                values: new object[] { new DateTime(2024, 9, 2, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6928), new DateTime(2024, 9, 17, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 9, 2, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6932), new DateTime(2024, 11, 1, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6931), new DateTime(2024, 9, 16, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6931) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a548cac-eff6-412c-8dc5-0198c24a66ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "455054fd-dbf3-455c-8bd6-74b89743a58a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90bb9065-7ac9-446a-b073-23c4b84005e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e04294e6-62a1-40fd-853b-36a43acb89ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcc7aac0-c111-4d2a-bc5f-68b739438d85");

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

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
    }
}
