using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class updatetableuserstatus1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2764), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2769), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2771), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2772), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2773), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2775), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2776), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2777), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2779), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2780), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2781), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2782), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2784), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2785), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2786), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2788), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2789), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2790), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2791), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2792), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2188), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2197), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2199), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2201), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2203), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2205), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2207), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2208), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2210), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2212), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2213), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2215), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2217), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2219), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2220), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2222), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2224), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2226), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2283), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2285), new DateTime(2024, 11, 11, 13, 52, 2, 365, DateTimeKind.Utc).AddTicks(2285) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetUsers");

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
        }
    }
}
