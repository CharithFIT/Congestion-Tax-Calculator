using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CongestionTaxCalculator.Repository.Migrations
{
    public partial class InsertCongestionTaxes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CongestionTaxes",
                columns: new[] { "Id", "Amount", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 1, 8, new TimeSpan(0, 6, 29, 0, 0), new TimeSpan(0, 6, 0, 0, 0) },
                    { 2, 13, new TimeSpan(0, 6, 59, 0, 0), new TimeSpan(0, 6, 30, 0, 0) },
                    { 3, 18, new TimeSpan(0, 7, 59, 0, 0), new TimeSpan(0, 7, 0, 0, 0) },
                    { 4, 13, new TimeSpan(0, 8, 29, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 5, 8, new TimeSpan(0, 14, 59, 0, 0), new TimeSpan(0, 8, 30, 0, 0) },
                    { 6, 13, new TimeSpan(0, 15, 29, 0, 0), new TimeSpan(0, 15, 0, 0, 0) },
                    { 8, 18, new TimeSpan(0, 16, 59, 0, 0), new TimeSpan(0, 15, 30, 0, 0) },
                    { 9, 13, new TimeSpan(0, 17, 59, 0, 0), new TimeSpan(0, 17, 0, 0, 0) },
                    { 10, 8, new TimeSpan(0, 18, 29, 0, 0), new TimeSpan(0, 18, 0, 0, 0) },
                    { 11, 0, new TimeSpan(0, 5, 59, 0, 0), new TimeSpan(0, 18, 30, 0, 0) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CongestionTaxes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CongestionTaxes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CongestionTaxes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CongestionTaxes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CongestionTaxes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CongestionTaxes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CongestionTaxes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CongestionTaxes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CongestionTaxes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CongestionTaxes",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
