using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datn.ApiManagement.Migrations
{
    public partial class UpdateVehicleTypeDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleTypeDetails_VehicleTypes_VehicleTypeId1",
                schema: "vehicleType",
                table: "VehicleTypeDetails");

            migrationBuilder.DropIndex(
                name: "IX_VehicleTypeDetails_VehicleTypeId1",
                schema: "vehicleType",
                table: "VehicleTypeDetails");

            migrationBuilder.DropColumn(
                name: "VehicleTypeId",
                schema: "vehicleType",
                table: "VehicleTypeDetails");

            migrationBuilder.DropColumn(
                name: "VehicleTypeId1",
                schema: "vehicleType",
                table: "VehicleTypeDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VehicleTypeId",
                schema: "vehicleType",
                table: "VehicleTypeDetails",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "VehicleTypeId1",
                schema: "vehicleType",
                table: "VehicleTypeDetails",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleTypeDetails_VehicleTypeId1",
                schema: "vehicleType",
                table: "VehicleTypeDetails",
                column: "VehicleTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleTypeDetails_VehicleTypes_VehicleTypeId1",
                schema: "vehicleType",
                table: "VehicleTypeDetails",
                column: "VehicleTypeId1",
                principalSchema: "vehicleType",
                principalTable: "VehicleTypes",
                principalColumn: "Id");
        }
    }
}
