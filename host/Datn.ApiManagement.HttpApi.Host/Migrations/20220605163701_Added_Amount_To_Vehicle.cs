using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datn.ApiManagement.Migrations
{
    public partial class Added_Amount_To_Vehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                schema: "vehicle",
                table: "Vehicles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnedVehicleDate",
                schema: "transaction",
                table: "UserTransactions",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AddColumn<int>(
                name: "TotalDays",
                schema: "transaction",
                table: "UserTransactions",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                schema: "vehicle",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "TotalDays",
                schema: "transaction",
                table: "UserTransactions");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnedVehicleDate",
                schema: "transaction",
                table: "UserTransactions",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);
        }
    }
}
