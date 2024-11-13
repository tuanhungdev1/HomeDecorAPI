using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class addcartdiscountcouponreviewtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems");

            migrationBuilder.DropTable(
                name: "FavoriteProducts");

            migrationBuilder.RenameColumn(
                name: "Subtotal",
                table: "Carts",
                newName: "Tax");

            migrationBuilder.RenameColumn(
                name: "ShippingCost",
                table: "Carts",
                newName: "ShippingFee");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Carts",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Carts",
                newName: "ExpiryDate");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "CartItems",
                newName: "ProductVariantId");

            migrationBuilder.RenameColumn(
                name: "AddedAt",
                table: "CartItems",
                newName: "CreatedAt");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                newName: "IX_CartItems_ProductVariantId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Carts",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Carts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "AppliedCouponId",
                table: "Carts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppliedDiscountId",
                table: "Carts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CouponCode",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountedUnitPrice",
                table: "CartItems",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "CartItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "CartItems",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UsageLimit = table.Column<int>(type: "int", nullable: false),
                    UsageCount = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WishlistItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductVariantId = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishlistItems", x => new { x.UserId, x.ProductVariantId, x.Id });
                    table.ForeignKey(
                        name: "FK_WishlistItems_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishlistItems_ProductVariants_ProductVariantId",
                        column: x => x.ProductVariantId,
                        principalTable: "ProductVariants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3933), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3939), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3941), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3942), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3943), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3945), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3946), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3947), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3949), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3950), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3952), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3953), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3954), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3956), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3957), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3958), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3960), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3961), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3962), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3964), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3351), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3364), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3366), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3368), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3370), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3372), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3372) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3374), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3376), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3378), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3379), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3381), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3383), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3385), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3387), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3389), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3391), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3393), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3395), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3397), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3398), new DateTime(2024, 11, 13, 13, 47, 34, 961, DateTimeKind.Utc).AddTicks(3399) });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_AppliedCouponId",
                table: "Carts",
                column: "AppliedCouponId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_AppliedDiscountId",
                table: "Carts",
                column: "AppliedDiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItems_ProductVariantId",
                table: "WishlistItems",
                column: "ProductVariantId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_ProductVariants_ProductVariantId",
                table: "CartItems",
                column: "ProductVariantId",
                principalTable: "ProductVariants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Coupons_AppliedCouponId",
                table: "Carts",
                column: "AppliedCouponId",
                principalTable: "Coupons",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Discounts_AppliedDiscountId",
                table: "Carts",
                column: "AppliedDiscountId",
                principalTable: "Discounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_ProductVariants_ProductVariantId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Coupons_AppliedCouponId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Discounts_AppliedDiscountId",
                table: "Carts");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "WishlistItems");

            migrationBuilder.DropIndex(
                name: "IX_Carts_AppliedCouponId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_AppliedDiscountId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_UserId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "AppliedCouponId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "AppliedDiscountId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CouponCode",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "DiscountedUnitPrice",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "CartItems");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Carts",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "Tax",
                table: "Carts",
                newName: "Subtotal");

            migrationBuilder.RenameColumn(
                name: "ShippingFee",
                table: "Carts",
                newName: "ShippingCost");

            migrationBuilder.RenameColumn(
                name: "ExpiryDate",
                table: "Carts",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "ProductVariantId",
                table: "CartItems",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "CartItems",
                newName: "AddedAt");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_ProductVariantId",
                table: "CartItems",
                newName: "IX_CartItems_ProductId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Carts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "FavoriteProducts",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7905), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7909), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7911), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7912), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7914), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7915), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7916), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7917), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7919), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7920), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7921), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7923), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7924), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7925), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7927), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7928), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7929), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7931), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7932), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7933), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7386), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7396), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7399), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7401), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7403), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7405), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7407), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7409), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7411), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7413), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7415), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7417), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7418), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7420), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7422), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7424), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7426), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7428), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7430), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7432), new DateTime(2024, 11, 12, 3, 38, 48, 58, DateTimeKind.Utc).AddTicks(7432) });

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteProducts_ProductId",
                table: "FavoriteProducts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
