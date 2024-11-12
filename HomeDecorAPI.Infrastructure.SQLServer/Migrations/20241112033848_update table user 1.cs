using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class updatetableuser1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "AspNetUsers");

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
    }
}
