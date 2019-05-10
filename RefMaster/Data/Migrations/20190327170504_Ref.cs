using Microsoft.EntityFrameworkCore.Migrations;

namespace RefMaster.Data.Migrations
{
    public partial class Ref : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "Referee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefereeName",
                table: "Referee",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Referee_MatchId",
                table: "Referee",
                column: "MatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Referee_Match_MatchId",
                table: "Referee",
                column: "MatchId",
                principalTable: "Match",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Referee_Match_MatchId",
                table: "Referee");

            migrationBuilder.DropIndex(
                name: "IX_Referee_MatchId",
                table: "Referee");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Referee");

            migrationBuilder.DropColumn(
                name: "RefereeName",
                table: "Referee");
        }
    }
}
