using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Garden.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    UserName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Email = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SecurityStamp = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Squarefoots",
                columns: table => new
                {
                    SquarefootId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SeedId = table.Column<int>(type: "int", nullable: false),
                    PlantDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HarvestDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PlotId = table.Column<int>(type: "int", nullable: false),
                    NeedsWater = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LastWaterDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Squarefoots", x => x.SquarefootId);
                });

            migrationBuilder.CreateTable(
                name: "Plots",
                columns: table => new
                {
                    PlotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Sun = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Soil = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Hardiness = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Privacy = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    UserId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plots", x => x.PlotId);
                    table.ForeignKey(
                        name: "FK_Plots_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Plots",
                columns: new[] { "PlotId", "Depth", "Hardiness", "Length", "Name", "Privacy", "Soil", "Sun", "UserId", "Width" },
                values: new object[] { 1, 0, 1, 6, "Small Plot", null, "Dirty", "Bright", null, 6 });

            migrationBuilder.InsertData(
                table: "Plots",
                columns: new[] { "PlotId", "Depth", "Hardiness", "Length", "Name", "Privacy", "Soil", "Sun", "UserId", "Width" },
                values: new object[] { 2, 0, 2, 12, "Medium Plot", null, "Moist", "Dark", null, 12 });

            migrationBuilder.InsertData(
                table: "Plots",
                columns: new[] { "PlotId", "Depth", "Hardiness", "Length", "Name", "Privacy", "Soil", "Sun", "UserId", "Width" },
                values: new object[] { 3, 0, 3, 18, "Large Plot", null, "Roosevelt", "Seven", null, 18 });

            migrationBuilder.CreateIndex(
                name: "IX_Plots_UserId",
                table: "Plots",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plots");

            migrationBuilder.DropTable(
                name: "Squarefoots");

            migrationBuilder.DropTable(
                name: "ApplicationUser");
        }
    }
}
