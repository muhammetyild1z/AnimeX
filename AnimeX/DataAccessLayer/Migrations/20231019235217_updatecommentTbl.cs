using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class updatecommentTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_comments",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "UserImg",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "comments");

            migrationBuilder.AddColumn<int>(
                name: "CommentUserId",
                table: "comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_comments",
                table: "comments",
                columns: new[] { "AnimeCommentID", "CommentID", "CommentUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_comments_CommentUserId",
                table: "comments",
                column: "CommentUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_AspNetUsers_CommentUserId",
                table: "comments",
                column: "CommentUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_AspNetUsers_CommentUserId",
                table: "comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_comments",
                table: "comments");

            migrationBuilder.DropIndex(
                name: "IX_comments_CommentUserId",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "CommentUserId",
                table: "comments");

            migrationBuilder.AddColumn<string>(
                name: "UserImg",
                table: "comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_comments",
                table: "comments",
                columns: new[] { "AnimeCommentID", "CommentID" });
        }
    }
}
