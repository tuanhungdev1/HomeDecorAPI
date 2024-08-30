using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class fixproductexpirytimediscountmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e9db225-c30f-41fe-a8b1-bd1552c30f22");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "634bdb99-8b03-4e5a-89dc-270dc86d1305");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b994d4d-5830-4c35-ac47-7d094a43ca41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5b08172-f6be-43cb-9289-c41ca35f72c6");

            migrationBuilder.DropColumn(
                name: "IsNew",
                table: "Products");

            migrationBuilder.AddColumn<DateTime>(
                name: "DiscountEndDate",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "IsNewExpiryDate",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1490694b-ff38-493b-85f4-c8cca2053e8b", null, "Admin", "ADMIN" },
                    { "8b41e8d6-a1dc-4c57-b026-03f8958c0a12", null, "ContentCreator", "ContentCreator" },
                    { "d783db09-56de-4934-85d7-0296e221a8d8", null, "Manager", "MANAGER" },
                    { "db159f7a-fc8c-453c-8ecc-7efd7a974b47", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 28, 53, 449, DateTimeKind.Utc).AddTicks(1823), new DateTime(2024, 9, 29, 7, 28, 53, 449, DateTimeKind.Utc).AddTicks(1816), new DateTime(2024, 9, 13, 7, 28, 53, 449, DateTimeKind.Utc).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 28, 53, 449, DateTimeKind.Utc).AddTicks(1826), null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 28, 53, 449, DateTimeKind.Utc).AddTicks(1829), new DateTime(2024, 10, 14, 7, 28, 53, 449, DateTimeKind.Utc).AddTicks(1828), new DateTime(2024, 9, 13, 7, 28, 53, 449, DateTimeKind.Utc).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 28, 53, 449, DateTimeKind.Utc).AddTicks(1832), new DateTime(2024, 9, 14, 7, 28, 53, 449, DateTimeKind.Utc).AddTicks(1831), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 28, 53, 449, DateTimeKind.Utc).AddTicks(1835), new DateTime(2024, 10, 29, 7, 28, 53, 449, DateTimeKind.Utc).AddTicks(1834), new DateTime(2024, 9, 13, 7, 28, 53, 449, DateTimeKind.Utc).AddTicks(1834) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1490694b-ff38-493b-85f4-c8cca2053e8b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b41e8d6-a1dc-4c57-b026-03f8958c0a12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d783db09-56de-4934-85d7-0296e221a8d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db159f7a-fc8c-453c-8ecc-7efd7a974b47");

            migrationBuilder.DropColumn(
                name: "DiscountEndDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsNewExpiryDate",
                table: "Products");

            migrationBuilder.AddColumn<bool>(
                name: "IsNew",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4e9db225-c30f-41fe-a8b1-bd1552c30f22", null, "Customer", "CUSTOMER" },
                    { "634bdb99-8b03-4e5a-89dc-270dc86d1305", null, "Manager", "MANAGER" },
                    { "7b994d4d-5830-4c35-ac47-7d094a43ca41", null, "Admin", "ADMIN" },
                    { "d5b08172-f6be-43cb-9289-c41ca35f72c6", null, "ContentCreator", "ContentCreator" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsNew" },
                values: new object[] { new DateTime(2024, 8, 29, 14, 33, 19, 395, DateTimeKind.Utc).AddTicks(6021), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IsNew" },
                values: new object[] { new DateTime(2024, 8, 29, 14, 33, 19, 395, DateTimeKind.Utc).AddTicks(6023), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsNew" },
                values: new object[] { new DateTime(2024, 8, 29, 14, 33, 19, 395, DateTimeKind.Utc).AddTicks(6026), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IsNew" },
                values: new object[] { new DateTime(2024, 8, 29, 14, 33, 19, 395, DateTimeKind.Utc).AddTicks(6028), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IsNew" },
                values: new object[] { new DateTime(2024, 8, 29, 14, 33, 19, 395, DateTimeKind.Utc).AddTicks(6030), true });
        }
    }
}
