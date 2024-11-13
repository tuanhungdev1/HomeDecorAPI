using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class initalCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressLine = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    State = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_AspNetUsers_UserId",
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
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8280), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8284), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8286), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8287), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8288), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8289), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8290), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8291), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8293), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8294), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8295), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8296), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8296) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8297), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8298), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8299), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8301), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8302), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8303), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8304), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8305), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7502), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7512), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7514), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7516), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7517), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7519), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7520), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7522), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7524), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7525), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7527), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7529), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7530), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7532), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7534), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7536), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7537), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7539), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7540), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7542), new DateTime(2024, 11, 13, 18, 15, 25, 770, DateTimeKind.Utc).AddTicks(7542) });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1054), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1059), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1060), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1061), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1062), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1063) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1064), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1065), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1066), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1067), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1068), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1069), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1071), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1072), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1073), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1074), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1076), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1077), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1077) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1078), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1079), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1079) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1080), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(584), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(595), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(597), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(599), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(600), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(602), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(604), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(612), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(613), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(615), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(617), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(618), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(650), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(652), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(654), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(655), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(657), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(659), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(661), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(663), new DateTime(2024, 11, 13, 18, 13, 1, 323, DateTimeKind.Utc).AddTicks(663) });
        }
    }
}
