using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datn.ApiManagement.Migrations
{
    public partial class UpdateVehicleTypeDetail2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "VehicleTypeId",
                schema: "vehicleType",
                table: "VehicleTypeDetails",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_VehicleTypeDetails_VehicleTypeId",
                schema: "vehicleType",
                table: "VehicleTypeDetails",
                column: "VehicleTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleTypeDetails_VehicleTypes_VehicleTypeId",
                schema: "vehicleType",
                table: "VehicleTypeDetails",
                column: "VehicleTypeId",
                principalSchema: "vehicleType",
                principalTable: "VehicleTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleTypeDetails_VehicleTypes_VehicleTypeId",
                schema: "vehicleType",
                table: "VehicleTypeDetails");

            migrationBuilder.DropIndex(
                name: "IX_VehicleTypeDetails_VehicleTypeId",
                schema: "vehicleType",
                table: "VehicleTypeDetails");

            migrationBuilder.DropColumn(
                name: "VehicleTypeId",
                schema: "vehicleType",
                table: "VehicleTypeDetails");
        }
    }
}
