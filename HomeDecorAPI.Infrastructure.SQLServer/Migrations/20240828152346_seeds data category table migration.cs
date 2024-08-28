using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class seedsdatacategorytablemigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cbed28d-eab1-4da3-9560-74fe4335fc18");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22913a08-c45a-487c-95a6-988791653503");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "762552fa-f639-4946-b4ae-7fda853dc5a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89b7480a-54d1-47a8-9772-d695f378b559");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37fc96f9-59cf-4484-9f53-7ac3dc0e71b1", null, "Manager", "MANAGER" },
                    { "7af0ae9a-25cf-4546-96e6-c41e829bea81", null, "ContentCreator", "ContentCreator" },
                    { "9a2a6374-80bc-48b0-8499-1036bc2f0001", null, "Customer", "CUSTOMER" },
                    { "f10e19fe-2752-4a7e-aa51-f17758dba697", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { 1, "All bedroom related furniture and accessories", "https://example.com/bedroom.jpg", "Bedroom", null },
                    { 6, "Furniture and accessories for the living room", "https://example.com/livingroom.jpg", "Living Room", null },
                    { 11, "Furniture and accessories for the dining room", "https://example.com/diningroom.jpg", "Dining Room", null },
                    { 15, "Furniture and accessories for the kitchen", "https://example.com/kitchen.jpg", "Kitchen", null },
                    { 18, "Furniture and accessories for outdoor spaces", "https://example.com/outdoor.jpg", "Outdoor", null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 28, 15, 23, 46, 68, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 28, 15, 23, 46, 68, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 28, 15, 23, 46, 68, DateTimeKind.Utc).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 28, 15, 23, 46, 68, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 28, 15, 23, 46, 68, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { 2, "Different types of beds", "https://example.com/beds.jpg", "Beds", 1 },
                    { 3, "Various bedroom lamps", "https://example.com/lamps.jpg", "Lamps", 1 },
                    { 4, "Wardrobes and storage solutions", "https://example.com/wardrobes.jpg", "Wardrobes", 1 },
                    { 5, "Dressers and bedroom storage", "https://example.com/dressers.jpg", "Dressers", 1 },
                    { 7, "Various types of sofas for the living room", "https://example.com/sofas.jpg", "Sofas", 6 },
                    { 8, "Coffee tables for the living room", "https://example.com/coffeetables.jpg", "Coffee Tables", 6 },
                    { 9, "TV stands and media units", "https://example.com/tvstands.jpg", "TV Stands", 6 },
                    { 10, "Bookcases and shelving units", "https://example.com/bookcases.jpg", "Bookcases", 6 },
                    { 12, "Dining tables for the dining room", "https://example.com/diningtables.jpg", "Dining Tables", 11 },
                    { 13, "Dining chairs for the dining room", "https://example.com/diningchairs.jpg", "Dining Chairs", 11 },
                    { 14, "Bar stools and counter seating", "https://example.com/barstools.jpg", "Bar Stools", 11 },
                    { 16, "Kitchen cabinets and storage solutions", "https://example.com/cabinets.jpg", "Cabinets", 15 },
                    { 17, "Kitchen islands and counters", "https://example.com/kitchenislands.jpg", "Kitchen Islands", 15 },
                    { 19, "Seating solutions for outdoor areas", "https://example.com/outdoorseating.jpg", "Outdoor Seating", 18 },
                    { 20, "Tables for outdoor dining and lounging", "https://example.com/outdoortables.jpg", "Outdoor Tables", 18 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37fc96f9-59cf-4484-9f53-7ac3dc0e71b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7af0ae9a-25cf-4546-96e6-c41e829bea81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a2a6374-80bc-48b0-8499-1036bc2f0001");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f10e19fe-2752-4a7e-aa51-f17758dba697");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0cbed28d-eab1-4da3-9560-74fe4335fc18", null, "Admin", "ADMIN" },
                    { "22913a08-c45a-487c-95a6-988791653503", null, "Customer", "CUSTOMER" },
                    { "762552fa-f639-4946-b4ae-7fda853dc5a1", null, "ContentCreator", "ContentCreator" },
                    { "89b7480a-54d1-47a8-9772-d695f378b559", null, "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 28, 15, 21, 36, 336, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 28, 15, 21, 36, 336, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 28, 15, 21, 36, 336, DateTimeKind.Utc).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 28, 15, 21, 36, 336, DateTimeKind.Utc).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 28, 15, 21, 36, 336, DateTimeKind.Utc).AddTicks(5472));
        }
    }
}
