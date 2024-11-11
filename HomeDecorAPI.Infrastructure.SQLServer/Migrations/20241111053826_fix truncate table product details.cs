using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class fixtruncatetableproductdetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Products_ProductId",
                table: "ProductDetails");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetails_ProductId",
                table: "ProductDetails");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Measurements",
                table: "ProductDetails",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7054), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7057), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7059), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7060), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7062), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7063), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7064), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7066), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7067), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7068), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7069), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7071), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7072), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7074), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7075), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7076), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7078), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7079), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7080), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7081), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6390), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6403), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6406), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6406) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6408), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6410), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6412), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6414), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6415), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6417), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6419), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6421), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6423), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6425), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6426), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6428), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6430), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6432), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6434), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6434) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6436), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6438), new DateTime(2024, 11, 11, 5, 38, 26, 297, DateTimeKind.Utc).AddTicks(6438) });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductId",
                table: "ProductDetails",
                column: "ProductId",
                unique: true,
                filter: "[ProductId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Products_ProductId",
                table: "ProductDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Products_ProductId",
                table: "ProductDetails");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetails_ProductId",
                table: "ProductDetails");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Measurements",
                table: "ProductDetails",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9248), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9251), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9253), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9254), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9255), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9256), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9257), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9259), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9260), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9261), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9291), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9291) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9292), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9293), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9294), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9294) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9295), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9296), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9298), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9299), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9300), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9301), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8688), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8727), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8729), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8731), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8733), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8735), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8736), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8738), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8739), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8741), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8743), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8745), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8746), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8748), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8749), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8751), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8753), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8754), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8756), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8758), new DateTime(2024, 11, 10, 13, 37, 24, 430, DateTimeKind.Utc).AddTicks(8758) });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductId",
                table: "ProductDetails",
                column: "ProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Products_ProductId",
                table: "ProductDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
