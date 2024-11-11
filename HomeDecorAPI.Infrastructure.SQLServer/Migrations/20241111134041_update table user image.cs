using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class updatetableuserimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_ProductVariants_ProductVariantId",
                table: "ProductImages");

            migrationBuilder.DropTable(
                name: "UserImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages");

            migrationBuilder.RenameTable(
                name: "ProductImages",
                newName: "ProductImage");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductVariantId",
                table: "ProductImage",
                newName: "IX_ProductImage_ProductVariantId");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImage",
                table: "ProductImage",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1492), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1498), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1499) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1500), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1501), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1502), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1503), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1505), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1506), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1507), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1508), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1509), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1510), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1512), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1513), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1515), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1515) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1516), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1517), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1518), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1520), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1521), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(970), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(972), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(974), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(976), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(977), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(979), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(980), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(982), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(984), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(986), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(987), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1026), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1028), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1030), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1032), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1033), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1035), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1037), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1038), new DateTime(2024, 11, 11, 13, 40, 41, 14, DateTimeKind.Utc).AddTicks(1039) });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImage_ProductVariants_ProductVariantId",
                table: "ProductImage",
                column: "ProductVariantId",
                principalTable: "ProductVariants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImage_ProductVariants_ProductVariantId",
                table: "ProductImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImage",
                table: "ProductImage");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "ProductImage",
                newName: "ProductImages");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImage_ProductVariantId",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductVariantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UserImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublicId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserImage_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_UserImage_UserId",
                table: "UserImage",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_ProductVariants_ProductVariantId",
                table: "ProductImages",
                column: "ProductVariantId",
                principalTable: "ProductVariants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
