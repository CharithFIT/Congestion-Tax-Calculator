using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CongestionTaxCalculator.Repository.Migrations
{
    public partial class InsertTaxExemptVehicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TaxExemptVehicles",
                columns: new[] { "Id", "VehicleCode", "VehicleName" },
                values: new object[,]
                {
                    { 1, "EmergencyVehicles", "Emergency Vehicles" },
                    { 2, "Busses", "Busses" },
                    { 3, "DiplomatVehicles", "Diplomat Vehicles" },
                    { 4, "Motorcycles", "Motorcycles" },
                    { 5, "MilitaryVehicles", "Military Vehicles" },
                    { 6, "ForeignVehicles", "Foreign Vehicles" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaxExemptVehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TaxExemptVehicles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TaxExemptVehicles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TaxExemptVehicles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TaxExemptVehicles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TaxExemptVehicles",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
