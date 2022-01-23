using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CongestionTaxCalculator.Repository.Migrations
{
    public partial class AlterTaxExemptVehicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VehicleTypeCode",
                table: "TaxExemptVehicles",
                newName: "VehicleCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VehicleCode",
                table: "TaxExemptVehicles",
                newName: "VehicleTypeCode");
        }
    }
}
