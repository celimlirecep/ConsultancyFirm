using Microsoft.EntityFrameworkCore.Migrations;

namespace ColsultancyFirm.DAL.Migrations
{
    public partial class edittingauthorheading : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorHeading");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuthorHeading",
                columns: table => new
                {
                    AuthorsAuthorId = table.Column<int>(type: "INTEGER", nullable: false),
                    HeadingsHeadingId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorHeading", x => new { x.AuthorsAuthorId, x.HeadingsHeadingId });
                    table.ForeignKey(
                        name: "FK_AuthorHeading_Authors_AuthorsAuthorId",
                        column: x => x.AuthorsAuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorHeading_Headings_HeadingsHeadingId",
                        column: x => x.HeadingsHeadingId,
                        principalTable: "Headings",
                        principalColumn: "HeadingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorHeading_HeadingsHeadingId",
                table: "AuthorHeading",
                column: "HeadingsHeadingId");
        }
    }
}
