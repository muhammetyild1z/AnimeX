using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class appUserAndCommentRevise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserImg",
                table: "comments");

            migrationBuilder.AddColumn<bool>(
                name: "CommentStatus",
                table: "comments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserImg",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentStatus",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "UserImg",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "UserImg",
                table: "comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
