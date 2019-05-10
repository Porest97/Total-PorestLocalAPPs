using Microsoft.EntityFrameworkCore.Migrations;

namespace PRO.Migrations
{
    public partial class Team2InMatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Team2",
                table: "Match",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Team2",
                table: "Match");
        }
    }
}
