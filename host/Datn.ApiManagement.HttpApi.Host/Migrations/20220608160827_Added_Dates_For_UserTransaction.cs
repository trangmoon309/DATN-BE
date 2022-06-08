using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datn.ApiManagement.Migrations
{
    public partial class Added_Dates_For_UserTransaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CancelDate",
                schema: "transaction",
                table: "UserTransactions",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DepositDate",
                schema: "transaction",
                table: "UserTransactions",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PayingDate",
                schema: "transaction",
                table: "UserTransactions",
                type: "timestamp without time zone",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CancelDate",
                schema: "transaction",
                table: "UserTransactions");

            migrationBuilder.DropColumn(
                name: "DepositDate",
                schema: "transaction",
                table: "UserTransactions");

            migrationBuilder.DropColumn(
                name: "PayingDate",
                schema: "transaction",
                table: "UserTransactions");
        }
    }
}
