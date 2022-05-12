using Microsoft.EntityFrameworkCore.Migrations;

namespace ColsultancyFirm.DAL.Migrations
{
    public partial class IsApprovedInHeadingsForLastCheck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Headings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Headings");
        }
    }
}
