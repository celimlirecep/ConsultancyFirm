using Microsoft.EntityFrameworkCore.Migrations;

namespace ColsultancyFirm.DAL.Migrations
{
    public partial class authorpageeditting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorImages",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "AuthorMail",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "AuthorPhone",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "AuthorUrl",
                table: "Authors",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "AuthorSurname",
                table: "Authors",
                newName: "AuthorAbout");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Authors",
                newName: "AuthorUrl");

            migrationBuilder.RenameColumn(
                name: "AuthorAbout",
                table: "Authors",
                newName: "AuthorSurname");

            migrationBuilder.AddColumn<string>(
                name: "AuthorImages",
                table: "Authors",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorMail",
                table: "Authors",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                table: "Authors",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorPhone",
                table: "Authors",
                type: "TEXT",
                nullable: true);
        }
    }
}
