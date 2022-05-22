using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datn.ApiManagement.Migrations
{
    public partial class Add_Images_To_Vehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehicleImages",
                schema: "vehicle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uuid", nullable: false),
                    FileInformationId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleImages_FileInformations_FileInformationId",
                        column: x => x.FileInformationId,
                        principalSchema: "files",
                        principalTable: "FileInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleImages_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "vehicle",
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImages_FileInformationId",
                schema: "vehicle",
                table: "VehicleImages",
                column: "FileInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleImages_VehicleId",
                schema: "vehicle",
                table: "VehicleImages",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleImages",
                schema: "vehicle");
        }
    }
}
