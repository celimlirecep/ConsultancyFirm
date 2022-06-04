using Microsoft.EntityFrameworkCore.Migrations;

namespace ColsultancyFirm.DAL.Migrations
{
    public partial class memberdeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MemberImageURL = table.Column<string>(type: "TEXT", nullable: true),
                    MemberMail = table.Column<string>(type: "TEXT", nullable: true),
                    MemberName = table.Column<string>(type: "TEXT", nullable: true),
                    MemberPasword = table.Column<string>(type: "TEXT", nullable: true),
                    MemberSurname = table.Column<string>(type: "TEXT", nullable: true),
                    MemberUsername = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberId);
                });
        }
    }
}
