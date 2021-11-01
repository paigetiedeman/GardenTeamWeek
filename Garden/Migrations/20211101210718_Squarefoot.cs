using Microsoft.EntityFrameworkCore.Migrations;

namespace Garden.Migrations
{
    public partial class Squarefoot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Squarefoots",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Squarefoots_UserId",
                table: "Squarefoots",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Squarefoots_ApplicationUser_UserId",
                table: "Squarefoots",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Squarefoots_ApplicationUser_UserId",
                table: "Squarefoots");

            migrationBuilder.DropIndex(
                name: "IX_Squarefoots_UserId",
                table: "Squarefoots");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Squarefoots");
        }
    }
}
