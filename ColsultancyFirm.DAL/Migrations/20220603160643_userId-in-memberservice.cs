using Microsoft.EntityFrameworkCore.Migrations;

namespace ColsultancyFirm.DAL.Migrations
{
    public partial class userIdinmemberservice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "MemberServices");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "MemberServices",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MemberServices");

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "MemberServices",
                type: "INTEGER",
                nullable: true);
        }
    }
}
