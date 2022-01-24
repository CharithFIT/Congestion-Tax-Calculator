using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CongestionTaxCalculator.Repository.Migrations
{
    public partial class InsertTaxExceptDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TaxExceptDates",
                columns: new[] { "Id", "Date" },
                values: new object[,]
                {
                    { 1, new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2013, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2013, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2013, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2013, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2013, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2013, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2013, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2013, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2013, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2013, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2013, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2013, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2013, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2013, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2013, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2013, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2013, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2013, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2013, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2013, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2013, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2013, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2013, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(2013, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(2013, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(2013, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(2013, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(2013, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(2013, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, new DateTime(2013, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, new DateTime(2013, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, new DateTime(2013, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, new DateTime(2013, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, new DateTime(2013, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, new DateTime(2013, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, new DateTime(2013, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, new DateTime(2013, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, new DateTime(2013, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, new DateTime(2013, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, new DateTime(2013, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TaxExceptDates",
                columns: new[] { "Id", "Date" },
                values: new object[,]
                {
                    { 43, new DateTime(2013, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, new DateTime(2013, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, new DateTime(2013, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, new DateTime(2013, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, new DateTime(2013, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, new DateTime(2013, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, new DateTime(2013, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, new DateTime(2013, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, new DateTime(2013, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, new DateTime(2013, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, new DateTime(2013, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, new DateTime(2013, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, new DateTime(2013, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, new DateTime(2013, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, new DateTime(2013, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, new DateTime(2013, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, new DateTime(2013, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, new DateTime(2013, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, new DateTime(2013, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, new DateTime(2013, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, new DateTime(2013, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, new DateTime(2013, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, new DateTime(2013, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, new DateTime(2013, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, new DateTime(2013, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, new DateTime(2013, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, new DateTime(2013, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, new DateTime(2013, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, new DateTime(2013, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, new DateTime(2013, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, new DateTime(2013, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, new DateTime(2013, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, new DateTime(2013, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, new DateTime(2013, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, new DateTime(2013, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, new DateTime(2013, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, new DateTime(2013, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, new DateTime(2013, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, new DateTime(2013, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, new DateTime(2013, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, new DateTime(2013, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, new DateTime(2013, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TaxExceptDates",
                columns: new[] { "Id", "Date" },
                values: new object[,]
                {
                    { 85, new DateTime(2013, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, new DateTime(2013, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, new DateTime(2013, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, new DateTime(2013, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, new DateTime(2013, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, new DateTime(2013, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, new DateTime(2013, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, new DateTime(2013, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, new DateTime(2013, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, new DateTime(2013, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, new DateTime(2013, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, new DateTime(2013, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, new DateTime(2013, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, new DateTime(2013, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, new DateTime(2013, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, new DateTime(2013, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 101, new DateTime(2013, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 102, new DateTime(2013, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 103, new DateTime(2013, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 104, new DateTime(2013, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 105, new DateTime(2013, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 106, new DateTime(2013, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 107, new DateTime(2013, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 108, new DateTime(2013, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 109, new DateTime(2013, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 110, new DateTime(2013, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 111, new DateTime(2013, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 112, new DateTime(2013, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 113, new DateTime(2013, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 114, new DateTime(2013, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 115, new DateTime(2013, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 116, new DateTime(2013, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 117, new DateTime(2013, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 118, new DateTime(2013, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 119, new DateTime(2013, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 120, new DateTime(2013, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 121, new DateTime(2013, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 122, new DateTime(2013, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 123, new DateTime(2013, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 124, new DateTime(2013, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 125, new DateTime(2013, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 126, new DateTime(2013, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TaxExceptDates",
                columns: new[] { "Id", "Date" },
                values: new object[,]
                {
                    { 127, new DateTime(2013, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 128, new DateTime(2013, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 129, new DateTime(2013, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 130, new DateTime(2013, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 131, new DateTime(2013, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 132, new DateTime(2013, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 133, new DateTime(2013, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 134, new DateTime(2013, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 135, new DateTime(2013, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 136, new DateTime(2013, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 137, new DateTime(2013, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 138, new DateTime(2013, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 139, new DateTime(2013, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 140, new DateTime(2013, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 141, new DateTime(2013, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 142, new DateTime(2013, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 143, new DateTime(2013, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 144, new DateTime(2013, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 145, new DateTime(2013, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 146, new DateTime(2013, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 147, new DateTime(2013, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 148, new DateTime(2013, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 149, new DateTime(2013, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 150, new DateTime(2013, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 151, new DateTime(2013, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "TaxExceptDates",
                keyColumn: "Id",
                keyValue: 151);
        }
    }
}
