using Microsoft.EntityFrameworkCore.Migrations;

namespace PoJ.Data.Migrations
{
    public partial class TEAMonPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Team",
                table: "Person");

            migrationBuilder.AddColumn<int>(
                name: "TeamId1",
                table: "Person",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_TeamId1",
                table: "Person",
                column: "TeamId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Team_TeamId1",
                table: "Person",
                column: "TeamId1",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Team_TeamId1",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_TeamId1",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "TeamId1",
                table: "Person");

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "Person",
                nullable: true);
        }
    }
}
