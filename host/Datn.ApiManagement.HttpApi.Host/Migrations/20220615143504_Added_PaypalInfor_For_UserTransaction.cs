using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datn.ApiManagement.Migrations
{
    public partial class Added_PaypalInfor_For_UserTransaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PayerIDPayPalId",
                schema: "transaction",
                table: "UserTransactions",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PaymenPayPalId",
                schema: "transaction",
                table: "UserTransactions",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PayerIDPayPalId",
                schema: "transaction",
                table: "UserTransactions");

            migrationBuilder.DropColumn(
                name: "PaymenPayPalId",
                schema: "transaction",
                table: "UserTransactions");
        }
    }
}
