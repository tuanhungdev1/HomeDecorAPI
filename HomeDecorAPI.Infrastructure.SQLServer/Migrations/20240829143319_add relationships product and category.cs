using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class addrelationshipsproductandcategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryProduct_Category_CategoriesId",
                table: "CategoryProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryProduct_Products_ProductsId",
                table: "CategoryProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryProduct",
                table: "CategoryProduct");

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

            migrationBuilder.RenameTable(
                name: "CategoryProduct",
                newName: "ProductCategory");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "ProductCategory",
                newName: "IX_ProductCategory_ProductsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory",
                columns: new[] { "CategoriesId", "ProductsId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4e9db225-c30f-41fe-a8b1-bd1552c30f22", null, "Customer", "CUSTOMER" },
                    { "634bdb99-8b03-4e5a-89dc-270dc86d1305", null, "Manager", "MANAGER" },
                    { "7b994d4d-5830-4c35-ac47-7d094a43ca41", null, "Admin", "ADMIN" },
                    { "d5b08172-f6be-43cb-9289-c41ca35f72c6", null, "ContentCreator", "ContentCreator" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 14, 33, 19, 395, DateTimeKind.Utc).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 14, 33, 19, 395, DateTimeKind.Utc).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 14, 33, 19, 395, DateTimeKind.Utc).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 14, 33, 19, 395, DateTimeKind.Utc).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 29, 14, 33, 19, 395, DateTimeKind.Utc).AddTicks(6030));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Category_CategoriesId",
                table: "ProductCategory",
                column: "CategoriesId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Products_ProductsId",
                table: "ProductCategory",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Category_CategoriesId",
                table: "ProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Products_ProductsId",
                table: "ProductCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e9db225-c30f-41fe-a8b1-bd1552c30f22");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "634bdb99-8b03-4e5a-89dc-270dc86d1305");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b994d4d-5830-4c35-ac47-7d094a43ca41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5b08172-f6be-43cb-9289-c41ca35f72c6");

            migrationBuilder.RenameTable(
                name: "ProductCategory",
                newName: "CategoryProduct");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategory_ProductsId",
                table: "CategoryProduct",
                newName: "IX_CategoryProduct_ProductsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryProduct",
                table: "CategoryProduct",
                columns: new[] { "CategoriesId", "ProductsId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryProduct_Category_CategoriesId",
                table: "CategoryProduct",
                column: "CategoriesId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryProduct_Products_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
