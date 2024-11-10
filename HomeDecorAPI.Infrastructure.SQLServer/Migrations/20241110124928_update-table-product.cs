using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class updatetableproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SupplierId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c50fcd4-3d59-4df8-8f6c-a7ab151b1e70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c298106d-f7d0-4c91-ad70-1fdd5181349e");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SupplierId",
                table: "Products",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SupplierId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d631aec8-46e1-41a2-a901-f5d991a84894");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d936cecc-57a8-49b1-8531-85edf0c5ea11");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrandId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c50fcd4-3d59-4df8-8f6c-a7ab151b1e70", null, "Admin", "ADMIN" },
                    { "c298106d-f7d0-4c91-ad70-1fdd5181349e", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3388), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3393), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3395), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3396), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3397), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3399), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3400), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3401), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3403), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3404), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3459), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3461), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3462), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3464), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3465), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3466), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3468), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3469), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3470), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3472), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2804), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2814), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2857), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2859), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2861), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2862), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2864), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2866), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2868), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2869), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2871), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2872), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2874), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2876), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2877), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2879), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2881), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2882), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2884), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2886), new DateTime(2024, 11, 1, 14, 47, 45, 548, DateTimeKind.Utc).AddTicks(2886) });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SupplierId",
                table: "Products",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
