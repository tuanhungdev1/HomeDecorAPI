using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class updateusermodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "Firstname");

            migrationBuilder.RenameColumn(
                name: "DisplayName",
                table: "AspNetUsers",
                newName: "Displayname");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "AspNetUsers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Displayname",
                table: "AspNetUsers",
                newName: "DisplayName");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

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
        }
    }
}
