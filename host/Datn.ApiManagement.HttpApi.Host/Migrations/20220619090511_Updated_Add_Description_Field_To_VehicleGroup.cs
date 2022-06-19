using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datn.ApiManagement.Migrations
{
    public partial class Updated_Add_Description_Field_To_VehicleGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "vehicleType",
                table: "VehicleTypes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "vehicleType",
                table: "VehicleTypeDetails",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                schema: "vehicleType",
                table: "VehicleTypeDetails",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "vehicle",
                table: "VehicleProperties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                schema: "vehicle",
                table: "VehicleProperties",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "vechielLine",
                table: "VehicleLines",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "vehicleType",
                table: "VehicleTypes");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "vehicleType",
                table: "VehicleTypeDetails");

            migrationBuilder.DropColumn(
                name: "Value",
                schema: "vehicleType",
                table: "VehicleTypeDetails");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "vehicle",
                table: "VehicleProperties");

            migrationBuilder.DropColumn(
                name: "Value",
                schema: "vehicle",
                table: "VehicleProperties");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "vechielLine",
                table: "VehicleLines");
        }
    }
}
