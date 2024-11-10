using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class updatetableproductvariant2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87535243-6a8b-4061-892b-fe44ff4d093d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba4abd43-fe07-4802-83f0-e2f1b5447acb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3625), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3629), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3631), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3632), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3633), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3634), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3635), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3636), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3672), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3674), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3675), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3676), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3677), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3678), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3679), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3681), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3682), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3683), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3684), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3685), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3075), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3084), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3086), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3088), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3090), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3091), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3093), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3094), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3096), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3098), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3099), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3101), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3102), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3104), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3106), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3107), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3109), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3111), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3112), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3114), new DateTime(2024, 11, 10, 13, 34, 42, 134, DateTimeKind.Utc).AddTicks(3114) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "87535243-6a8b-4061-892b-fe44ff4d093d", null, "Customer", "CUSTOMER" },
                    { "ba4abd43-fe07-4802-83f0-e2f1b5447acb", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9606), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9610), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9611), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9613), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9614), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9615), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9616), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9617), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9618), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9620), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9621), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9622), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9623), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9624), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9626), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9627), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9627) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9628), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9629), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9630), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9631), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(8988), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(8997), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(8999), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9001), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9003), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9005), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9006), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9008), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9010), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9011), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9013), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9015), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9016), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9018), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9019), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9021), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9022), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9024), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9026), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9027), new DateTime(2024, 11, 10, 13, 22, 28, 149, DateTimeKind.Utc).AddTicks(9028) });
        }
    }
}
