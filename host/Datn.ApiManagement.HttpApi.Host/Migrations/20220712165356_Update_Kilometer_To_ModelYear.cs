using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datn.ApiManagement.Migrations
{
    public partial class Update_Kilometer_To_ModelYear : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KilometerTravel",
                schema: "vehicle",
                table: "Vehicles",
                newName: "ModelYear");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModelYear",
                schema: "vehicle",
                table: "Vehicles",
                newName: "KilometerTravel");
        }
    }
}
