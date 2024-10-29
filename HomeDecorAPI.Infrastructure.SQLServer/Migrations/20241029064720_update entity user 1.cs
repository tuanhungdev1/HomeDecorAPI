using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class updateentityuser1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0691197b-5974-4a32-aeb3-271a0204c87e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4069941b-57f6-4cd8-9c72-2196162db3c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d9bc656-a280-4f5d-a5b7-15c3c9fbb1c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89ef8be6-16fa-4643-8c6b-4ae6634a429e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a179edda-0d0b-4fa2-b7a4-07cb03428697");

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brands_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37c62394-4336-48e2-8a30-89e2267c014b", null, "Moderator", "MODERATOR" },
                    { "384179f8-d39f-4d72-9ae0-616cf3e1bbf7", null, "Customer", "CUSTOMER" },
                    { "556bd86d-5201-4212-936f-de9987aace19", null, "Manager", "MANAGER" },
                    { "be95ba39-ed7b-4e69-80d9-e9fad7913f40", null, "ContentCreator", "CONTENTCREATOR" },
                    { "d27c1c7e-f2b3-448d-a9d4-548e94d853b4", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrandId", "CreatedDate", "DiscountEndDate", "IsNewExpiryDate", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 10, 29, 6, 47, 19, 526, DateTimeKind.Utc).AddTicks(4136), new DateTime(2024, 11, 28, 6, 47, 19, 526, DateTimeKind.Utc).AddTicks(4129), new DateTime(2024, 11, 12, 6, 47, 19, 526, DateTimeKind.Utc).AddTicks(4135), new DateTime(2024, 10, 29, 6, 47, 19, 526, DateTimeKind.Utc).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "CreatedDate", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 10, 29, 6, 47, 19, 526, DateTimeKind.Utc).AddTicks(4140), new DateTime(2024, 10, 29, 6, 47, 19, 526, DateTimeKind.Utc).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrandId", "CreatedDate", "DiscountEndDate", "IsNewExpiryDate", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 10, 29, 6, 47, 19, 526, DateTimeKind.Utc).AddTicks(4145), new DateTime(2024, 12, 13, 6, 47, 19, 526, DateTimeKind.Utc).AddTicks(4143), new DateTime(2024, 11, 12, 6, 47, 19, 526, DateTimeKind.Utc).AddTicks(4144), new DateTime(2024, 10, 29, 6, 47, 19, 526, DateTimeKind.Utc).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BrandId", "CreatedDate", "DiscountEndDate", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 10, 29, 6, 47, 19, 526, DateTimeKind.Utc).AddTicks(4148), new DateTime(2024, 11, 13, 6, 47, 19, 526, DateTimeKind.Utc).AddTicks(4147), new DateTime(2024, 10, 29, 6, 47, 19, 526, DateTimeKind.Utc).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BrandId", "CreatedDate", "DiscountEndDate", "IsNewExpiryDate", "UpdatedDate" },
                values: new object[] { null, new DateTime(2024, 10, 29, 6, 47, 19, 526, DateTimeKind.Utc).AddTicks(4152), new DateTime(2024, 12, 28, 6, 47, 19, 526, DateTimeKind.Utc).AddTicks(4151), new DateTime(2024, 11, 12, 6, 47, 19, 526, DateTimeKind.Utc).AddTicks(4152), new DateTime(2024, 10, 29, 6, 47, 19, 526, DateTimeKind.Utc).AddTicks(4153) });

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_SupplierId",
                table: "Brands",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Products_BrandId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37c62394-4336-48e2-8a30-89e2267c014b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "384179f8-d39f-4d72-9ae0-616cf3e1bbf7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "556bd86d-5201-4212-936f-de9987aace19");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be95ba39-ed7b-4e69-80d9-e9fad7913f40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d27c1c7e-f2b3-448d-a9d4-548e94d853b4");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Products");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0691197b-5974-4a32-aeb3-271a0204c87e", null, "Manager", "MANAGER" },
                    { "4069941b-57f6-4cd8-9c72-2196162db3c2", null, "Customer", "CUSTOMER" },
                    { "7d9bc656-a280-4f5d-a5b7-15c3c9fbb1c6", null, "Moderator", "MODERATOR" },
                    { "89ef8be6-16fa-4643-8c6b-4ae6634a429e", null, "Admin", "ADMIN" },
                    { "a179edda-0d0b-4fa2-b7a4-07cb03428697", null, "ContentCreator", "CONTENTCREATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 18, 9, 43, 47, 68, DateTimeKind.Utc).AddTicks(8725), new DateTime(2024, 11, 17, 9, 43, 47, 68, DateTimeKind.Utc).AddTicks(8717), new DateTime(2024, 11, 1, 9, 43, 47, 68, DateTimeKind.Utc).AddTicks(8724), new DateTime(2024, 10, 18, 9, 43, 47, 68, DateTimeKind.Utc).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 18, 9, 43, 47, 68, DateTimeKind.Utc).AddTicks(8728), new DateTime(2024, 10, 18, 9, 43, 47, 68, DateTimeKind.Utc).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 18, 9, 43, 47, 68, DateTimeKind.Utc).AddTicks(8732), new DateTime(2024, 12, 2, 9, 43, 47, 68, DateTimeKind.Utc).AddTicks(8731), new DateTime(2024, 11, 1, 9, 43, 47, 68, DateTimeKind.Utc).AddTicks(8731), new DateTime(2024, 10, 18, 9, 43, 47, 68, DateTimeKind.Utc).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DiscountEndDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 18, 9, 43, 47, 68, DateTimeKind.Utc).AddTicks(8735), new DateTime(2024, 11, 2, 9, 43, 47, 68, DateTimeKind.Utc).AddTicks(8735), new DateTime(2024, 10, 18, 9, 43, 47, 68, DateTimeKind.Utc).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 18, 9, 43, 47, 68, DateTimeKind.Utc).AddTicks(8739), new DateTime(2024, 12, 17, 9, 43, 47, 68, DateTimeKind.Utc).AddTicks(8738), new DateTime(2024, 11, 1, 9, 43, 47, 68, DateTimeKind.Utc).AddTicks(8738), new DateTime(2024, 10, 18, 9, 43, 47, 68, DateTimeKind.Utc).AddTicks(8740) });
        }
    }
}
