using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class connectusertablewithuserImagetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_UserId",
                table: "Carts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a548cac-eff6-412c-8dc5-0198c24a66ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "455054fd-dbf3-455c-8bd6-74b89743a58a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90bb9065-7ac9-446a-b073-23c4b84005e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e04294e6-62a1-40fd-853b-36a43acb89ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcc7aac0-c111-4d2a-bc5f-68b739438d85");

            migrationBuilder.DropColumn(
                name: "CouponCode",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "ItemDiscount",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "SKU",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Carts",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "DiscountAmount",
                table: "Carts",
                newName: "Subtotal");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Carts",
                newName: "CreatedDate");

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
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "Carts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ShippingCost",
                table: "Carts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "UserImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PublicId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24e8460f-3ce6-40bc-9054-1a7d1ec9af5e", null, "ContentCreator", "CONTENTCREATOR" },
                    { "50a503b4-eac3-4bcd-b501-e20d5fa99c4e", null, "Manager", "MANAGER" },
                    { "b31e2b26-d39e-4483-8c9b-4aeebe24e104", null, "Admin", "ADMIN" },
                    { "cbe306c9-f6e7-49fe-b24a-4bae845bec86", null, "Moderator", "MODERATOR" },
                    { "e0c450da-b021-4f88-b6de-93d4fc827821", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 5, 24, 23, 35, DateTimeKind.Utc).AddTicks(3561), new DateTime(2024, 11, 16, 5, 24, 23, 35, DateTimeKind.Utc).AddTicks(3554), new DateTime(2024, 10, 31, 5, 24, 23, 35, DateTimeKind.Utc).AddTicks(3560), new DateTime(2024, 10, 17, 5, 24, 23, 35, DateTimeKind.Utc).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 5, 24, 23, 35, DateTimeKind.Utc).AddTicks(3566), new DateTime(2024, 10, 17, 5, 24, 23, 35, DateTimeKind.Utc).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 5, 24, 23, 35, DateTimeKind.Utc).AddTicks(3571), new DateTime(2024, 12, 1, 5, 24, 23, 35, DateTimeKind.Utc).AddTicks(3569), new DateTime(2024, 10, 31, 5, 24, 23, 35, DateTimeKind.Utc).AddTicks(3570), new DateTime(2024, 10, 17, 5, 24, 23, 35, DateTimeKind.Utc).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DiscountEndDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 5, 24, 23, 35, DateTimeKind.Utc).AddTicks(3574), new DateTime(2024, 11, 1, 5, 24, 23, 35, DateTimeKind.Utc).AddTicks(3573), new DateTime(2024, 10, 17, 5, 24, 23, 35, DateTimeKind.Utc).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 17, 5, 24, 23, 35, DateTimeKind.Utc).AddTicks(3578), new DateTime(2024, 12, 16, 5, 24, 23, 35, DateTimeKind.Utc).AddTicks(3577), new DateTime(2024, 10, 31, 5, 24, 23, 35, DateTimeKind.Utc).AddTicks(3577), new DateTime(2024, 10, 17, 5, 24, 23, 35, DateTimeKind.Utc).AddTicks(3579) });

            migrationBuilder.CreateIndex(
                name: "IX_UserImage_UserId",
                table: "UserImage",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserImage");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24e8460f-3ce6-40bc-9054-1a7d1ec9af5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50a503b4-eac3-4bcd-b501-e20d5fa99c4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b31e2b26-d39e-4483-8c9b-4aeebe24e104");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbe306c9-f6e7-49fe-b24a-4bae845bec86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0c450da-b021-4f88-b6de-93d4fc827821");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "ShippingCost",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "Subtotal",
                table: "Carts",
                newName: "DiscountAmount");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "Carts",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Carts",
                newName: "CreatedAt");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Carts",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "CouponCode",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "ItemDiscount",
                table: "CartItems",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SKU",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "CartItems",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a548cac-eff6-412c-8dc5-0198c24a66ed", null, "Admin", "ADMIN" },
                    { "455054fd-dbf3-455c-8bd6-74b89743a58a", null, "Manager", "MANAGER" },
                    { "90bb9065-7ac9-446a-b073-23c4b84005e8", null, "Customer", "CUSTOMER" },
                    { "e04294e6-62a1-40fd-853b-36a43acb89ea", null, "ContentCreator", "CONTENTCREATOR" },
                    { "fcc7aac0-c111-4d2a-bc5f-68b739438d85", null, "Moderator", "MODERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 9, 2, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6914), new DateTime(2024, 10, 2, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6882), new DateTime(2024, 9, 16, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 9, 2, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6923), new DateTime(2024, 10, 17, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6921), new DateTime(2024, 9, 16, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DiscountEndDate" },
                values: new object[] { new DateTime(2024, 9, 2, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6928), new DateTime(2024, 9, 17, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DiscountEndDate", "IsNewExpiryDate" },
                values: new object[] { new DateTime(2024, 9, 2, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6932), new DateTime(2024, 11, 1, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6931), new DateTime(2024, 9, 16, 21, 33, 21, 439, DateTimeKind.Utc).AddTicks(6931) });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
