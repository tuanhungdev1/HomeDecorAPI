using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class updatetableproductvariant1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d631aec8-46e1-41a2-a901-f5d991a84894");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d936cecc-57a8-49b1-8531-85edf0c5ea11");

            migrationBuilder.DropColumn(
                name: "IsNewEndDate",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "IsNewStartDate",
                table: "ProductVariants");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87535243-6a8b-4061-892b-fe44ff4d093d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba4abd43-fe07-4802-83f0-e2f1b5447acb");

            migrationBuilder.AddColumn<DateTime>(
                name: "IsNewEndDate",
                table: "ProductVariants",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "IsNewStartDate",
                table: "ProductVariants",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d631aec8-46e1-41a2-a901-f5d991a84894", null, "Admin", "ADMIN" },
                    { "d936cecc-57a8-49b1-8531-85edf0c5ea11", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4831), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4836), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4837), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4838), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4840), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4841), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4842), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4843), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4845), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4846), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4847), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4848), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4849), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4850), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4852), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4853), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4854), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4855), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4856), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4857), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4858) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4289), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4299), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4301), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4303), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4305), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4306), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4308), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4310), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4311), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4313), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4315), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4316), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4318), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4320), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4321), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4323), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4325), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4326), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4328), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4330), new DateTime(2024, 11, 10, 12, 49, 27, 527, DateTimeKind.Utc).AddTicks(4330) });
        }
    }
}
