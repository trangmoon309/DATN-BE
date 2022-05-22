using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datn.ApiManagement.Migrations
{
    public partial class Update_User_Transaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                schema: "transaction",
                table: "UserTransactionVehicles",
                newName: "UserTransactionId");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                schema: "transaction",
                table: "UserTransactionVehicles",
                newName: "ReviewRideQuality");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "vehicle",
                table: "Vehicles",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReviewEngineQuality",
                schema: "transaction",
                table: "UserTransactionVehicles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ReviewNote",
                schema: "transaction",
                table: "UserTransactionVehicles",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserTransactionVehicles_UserTransactionId",
                schema: "transaction",
                table: "UserTransactionVehicles",
                column: "UserTransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTransactionVehicles_UserTransactions_UserTransactionId",
                schema: "transaction",
                table: "UserTransactionVehicles",
                column: "UserTransactionId",
                principalSchema: "transaction",
                principalTable: "UserTransactions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTransactionVehicles_UserTransactions_UserTransactionId",
                schema: "transaction",
                table: "UserTransactionVehicles");

            migrationBuilder.DropIndex(
                name: "IX_UserTransactionVehicles_UserTransactionId",
                schema: "transaction",
                table: "UserTransactionVehicles");

            migrationBuilder.DropColumn(
                name: "Name",
                schema: "vehicle",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ReviewEngineQuality",
                schema: "transaction",
                table: "UserTransactionVehicles");

            migrationBuilder.DropColumn(
                name: "ReviewNote",
                schema: "transaction",
                table: "UserTransactionVehicles");

            migrationBuilder.RenameColumn(
                name: "UserTransactionId",
                schema: "transaction",
                table: "UserTransactionVehicles",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ReviewRideQuality",
                schema: "transaction",
                table: "UserTransactionVehicles",
                newName: "Quantity");
        }
    }
}
