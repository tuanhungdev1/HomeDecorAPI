using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class Createproductfavoritetablemigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CouponCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteProducts",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteProducts", x => new { x.UserId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_FavoriteProducts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsVerifiedPurchase = table.Column<bool>(type: "bit", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: true),
                    Dislikes = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ItemDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26188004-1eae-4c3d-bbe0-471366ef48fa", null, "ContentCreator", "ContentCreator" },
                    { "4c51448d-98c6-464b-9899-8a4c017bc213", null, "Manager", "MANAGER" },
                    { "670aebbc-1700-4642-ba0c-249ca770ddbd", null, "Customer", "CUSTOMER" },
                    { "d90e0edc-2d45-44b1-a5fc-22e021dc1d17", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 9, 2, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(868), new DateTime(2024, 10, 2, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(860), new DateTime(2024, 9, 16, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 9, 2, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(875), new DateTime(2024, 10, 17, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(873), new DateTime(2024, 9, 16, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DiscountEndDate" },
                values: new object[] { new DateTime(2024, 9, 2, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(878), new DateTime(2024, 9, 17, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 9, 2, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(882), new DateTime(2024, 11, 1, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(880), new DateTime(2024, 9, 16, 20, 23, 25, 30, DateTimeKind.Utc).AddTicks(881) });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteProducts_ProductId",
                table: "FavoriteProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "FavoriteProducts");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26188004-1eae-4c3d-bbe0-471366ef48fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c51448d-98c6-464b-9899-8a4c017bc213");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "670aebbc-1700-4642-ba0c-249ca770ddbd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d90e0edc-2d45-44b1-a5fc-22e021dc1d17");

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
                column: "CreatedDate",
                value: new DateTime(2024, 8, 30, 7, 28, 53, 449, DateTimeKind.Utc).AddTicks(1826));

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
                columns: new[] { "CreatedDate", "DiscountEndDate" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 28, 53, 449, DateTimeKind.Utc).AddTicks(1832), new DateTime(2024, 9, 14, 7, 28, 53, 449, DateTimeKind.Utc).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 28, 53, 449, DateTimeKind.Utc).AddTicks(1835), new DateTime(2024, 10, 29, 7, 28, 53, 449, DateTimeKind.Utc).AddTicks(1834), new DateTime(2024, 9, 13, 7, 28, 53, 449, DateTimeKind.Utc).AddTicks(1834) });
        }
    }
}
