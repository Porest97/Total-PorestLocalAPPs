using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RefMaster.Data.Migrations
{
    public partial class Match : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefTypeName",
                table: "RefType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefDistriktName",
                table: "RefDistrikt",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefCategoryTypeName",
                table: "RefCategoryType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefCategoryName",
                table: "RefCategory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClubName",
                table: "Club",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RefereeId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Arena",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArenaName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arena", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Referee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RefereeNumber = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SeriesName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MatchDateTime = table.Column<DateTime>(nullable: false),
                    ArenaId = table.Column<int>(nullable: true),
                    Team1Id = table.Column<int>(nullable: true),
                    Team2Id = table.Column<int>(nullable: true),
                    Team1Score = table.Column<int>(nullable: true),
                    Team2Score = table.Column<int>(nullable: true),
                    Ref1Id = table.Column<int>(nullable: true),
                    Ref2Id = table.Column<int>(nullable: true),
                    Ref3Id = table.Column<int>(nullable: true),
                    Ref4Id = table.Column<int>(nullable: true),
                    Ref5Id = table.Column<int>(nullable: true),
                    RefereeId = table.Column<string>(nullable: true),
                    SeriesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Match_Arena_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Match_Referee_Ref1Id",
                        column: x => x.Ref1Id,
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Match_Referee_Ref2Id",
                        column: x => x.Ref2Id,
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Match_Referee_Ref3Id",
                        column: x => x.Ref3Id,
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Match_Referee_Ref4Id",
                        column: x => x.Ref4Id,
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Match_Referee_Ref5Id",
                        column: x => x.Ref5Id,
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Match_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Match_Club_Team1Id",
                        column: x => x.Team1Id,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Match_Club_Team2Id",
                        column: x => x.Team2Id,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RefereeId",
                table: "AspNetUsers",
                column: "RefereeId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_ArenaId",
                table: "Match",
                column: "ArenaId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Ref1Id",
                table: "Match",
                column: "Ref1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Ref2Id",
                table: "Match",
                column: "Ref2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Ref3Id",
                table: "Match",
                column: "Ref3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Ref4Id",
                table: "Match",
                column: "Ref4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Ref5Id",
                table: "Match",
                column: "Ref5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Match_SeriesId",
                table: "Match",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Team1Id",
                table: "Match",
                column: "Team1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Team2Id",
                table: "Match",
                column: "Team2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Referee_RefereeId",
                table: "AspNetUsers",
                column: "RefereeId",
                principalTable: "Referee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Referee_RefereeId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Match");

            migrationBuilder.DropTable(
                name: "Arena");

            migrationBuilder.DropTable(
                name: "Referee");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_RefereeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefTypeName",
                table: "RefType");

            migrationBuilder.DropColumn(
                name: "RefDistriktName",
                table: "RefDistrikt");

            migrationBuilder.DropColumn(
                name: "RefCategoryTypeName",
                table: "RefCategoryType");

            migrationBuilder.DropColumn(
                name: "RefCategoryName",
                table: "RefCategory");

            migrationBuilder.DropColumn(
                name: "ClubName",
                table: "Club");

            migrationBuilder.DropColumn(
                name: "RefereeId",
                table: "AspNetUsers");
        }
    }
}
