using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class registerusermigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4425ecef-6533-48f4-92c9-eef72d8759f9", null, "Admin", "ADMIN" },
                    { "5b93e0e8-f2f0-4c87-a099-be9659424361", null, "Customer", "CUSTOMER" },
                    { "77a9e38d-7c7b-4e61-a868-6efe2cd56f63", null, "Manager", "MANAGER" },
                    { "cc35f7f8-4353-48a0-a915-32f4caf81c77", null, "Vender", "Vender" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4425ecef-6533-48f4-92c9-eef72d8759f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b93e0e8-f2f0-4c87-a099-be9659424361");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77a9e38d-7c7b-4e61-a868-6efe2cd56f63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc35f7f8-4353-48a0-a915-32f4caf81c77");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

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
    }
}
