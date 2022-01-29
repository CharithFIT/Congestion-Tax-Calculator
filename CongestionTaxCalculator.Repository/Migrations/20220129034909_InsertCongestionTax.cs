using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CongestionTaxCalculator.Repository.Migrations
{
    public partial class InsertCongestionTax : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CongestionTaxes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.InsertData(
                table: "CongestionTaxes",
                columns: new[] { "Id", "Amount", "EndTime", "StartTime" },
                values: new object[] { 12, 0, new TimeSpan(0, 23, 59, 0, 0), new TimeSpan(0, 18, 30, 0, 0) });

            migrationBuilder.InsertData(
                table: "CongestionTaxes",
                columns: new[] { "Id", "Amount", "EndTime", "StartTime" },
                values: new object[] { 13, 0, new TimeSpan(0, 5, 59, 0, 0), new TimeSpan(0, 0, 0, 0, 0) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CongestionTaxes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CongestionTaxes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.InsertData(
                table: "CongestionTaxes",
                columns: new[] { "Id", "Amount", "EndTime", "StartTime" },
                values: new object[] { 11, 0, new TimeSpan(0, 5, 59, 0, 0), new TimeSpan(0, 18, 30, 0, 0) });
        }
    }
}
