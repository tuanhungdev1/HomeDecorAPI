using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class fixaddresstypeaddresstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9890), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9896), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9898), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9899), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9900), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9901), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9902), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9903), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9904), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9906), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9907), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9908), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9909), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9910), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9912), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9913), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9914), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9915), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9916), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9917), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9423), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9433), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9435), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9437), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9438), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9440), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9441), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9443), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9444), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9446), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9448), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9449), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9451), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9453), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9454), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9456), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9457), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9459), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9461), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9462), new DateTime(2024, 11, 13, 18, 56, 57, 178, DateTimeKind.Utc).AddTicks(9463) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Addresses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7651), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7657), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7658), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7659), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7660), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7662), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7663), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7664), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7665), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7666), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7667), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7669), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7670), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7671), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7672), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7673), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7674), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7675), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7676), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7678), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7125), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7135), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7138), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7139), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7141), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7143), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7145), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7146), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7148), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7150), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7151), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7208), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7210), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7212), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7214), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7215), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7217), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7218), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7220), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7222), new DateTime(2024, 11, 13, 18, 42, 32, 470, DateTimeKind.Utc).AddTicks(7222) });
        }
    }
}
