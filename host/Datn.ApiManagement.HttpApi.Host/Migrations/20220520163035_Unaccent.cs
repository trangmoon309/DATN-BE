using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datn.ApiManagement.Migrations
{
    public partial class Unaccent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE EXTENSION IF NOT EXISTS unaccent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP EXTENSION IF EXISTS unaccent");
        }
    }
}
