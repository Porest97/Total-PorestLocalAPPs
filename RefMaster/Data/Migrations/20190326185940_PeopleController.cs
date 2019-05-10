using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RefMaster.Data.Migrations
{
    public partial class PeopleController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefCategoryType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefCategoryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefDistrikt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefDistrikt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    RefNumber = table.Column<int>(nullable: true),
                    BirthDate = table.Column<string>(nullable: true),
                    RefTypeId = table.Column<int>(nullable: true),
                    RefCategoryId = table.Column<int>(nullable: true),
                    RefCategoryTypeId = table.Column<int>(nullable: true),
                    RefDistriktId = table.Column<int>(nullable: true),
                    ClubId = table.Column<int>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    Zipcode = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_Club_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_RefCategory_RefCategoryId",
                        column: x => x.RefCategoryId,
                        principalTable: "RefCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_RefCategoryType_RefCategoryTypeId",
                        column: x => x.RefCategoryTypeId,
                        principalTable: "RefCategoryType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_RefDistrikt_RefDistriktId",
                        column: x => x.RefDistriktId,
                        principalTable: "RefDistrikt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_RefType_RefTypeId",
                        column: x => x.RefTypeId,
                        principalTable: "RefType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_ClubId",
                table: "Person",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_RefCategoryId",
                table: "Person",
                column: "RefCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_RefCategoryTypeId",
                table: "Person",
                column: "RefCategoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_RefDistriktId",
                table: "Person",
                column: "RefDistriktId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_RefTypeId",
                table: "Person",
                column: "RefTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Club");

            migrationBuilder.DropTable(
                name: "RefCategory");

            migrationBuilder.DropTable(
                name: "RefCategoryType");

            migrationBuilder.DropTable(
                name: "RefDistrikt");

            migrationBuilder.DropTable(
                name: "RefType");
        }
    }
}
