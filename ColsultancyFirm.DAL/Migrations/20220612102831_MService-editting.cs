using Microsoft.EntityFrameworkCore.Migrations;

namespace ColsultancyFirm.DAL.Migrations
{
    public partial class MServiceeditting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "MemberServices",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "HeadingName",
                table: "Headings",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HeadingContent",
                table: "Headings",
                type: "TEXT",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MemberServices_AuthorId",
                table: "MemberServices",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberServices_CategoryId",
                table: "MemberServices",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_MemberServices_Authors_AuthorId",
                table: "MemberServices",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberServices_Categories_CategoryId",
                table: "MemberServices",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberServices_Authors_AuthorId",
                table: "MemberServices");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberServices_Categories_CategoryId",
                table: "MemberServices");

            migrationBuilder.DropIndex(
                name: "IX_MemberServices_AuthorId",
                table: "MemberServices");

            migrationBuilder.DropIndex(
                name: "IX_MemberServices_CategoryId",
                table: "MemberServices");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "MemberServices");

            migrationBuilder.AlterColumn<string>(
                name: "HeadingName",
                table: "Headings",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "HeadingContent",
                table: "Headings",
                type: "TEXT",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 1000);
        }
    }
}
