using Microsoft.EntityFrameworkCore.Migrations;

namespace Garden.Migrations
{
    public partial class SeedDBUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Seeds",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zone",
                table: "Seeds",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Seeds");

            migrationBuilder.DropColumn(
                name: "Zone",
                table: "Seeds");
        }
    }
}
