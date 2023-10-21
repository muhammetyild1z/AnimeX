using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class commentCommentIdAddIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_Animelers_AnimeCommentID",
                table: "comments");

            migrationBuilder.DropForeignKey(
                name: "FK_comments_AspNetUsers_CommentUserId",
                table: "comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_comments",
                table: "comments");

            migrationBuilder.DropIndex(
                name: "IX_comments_CommentUserId",
                table: "comments");

            migrationBuilder.AddColumn<int>(
                name: "animelerAnimeID",
                table: "comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "appUserId",
                table: "comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_comments",
                table: "comments",
                column: "CommentID");

            migrationBuilder.CreateIndex(
                name: "IX_comments_animelerAnimeID",
                table: "comments",
                column: "animelerAnimeID");

            migrationBuilder.CreateIndex(
                name: "IX_comments_appUserId",
                table: "comments",
                column: "appUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_Animelers_animelerAnimeID",
                table: "comments",
                column: "animelerAnimeID",
                principalTable: "Animelers",
                principalColumn: "AnimeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comments_AspNetUsers_appUserId",
                table: "comments",
                column: "appUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_Animelers_animelerAnimeID",
                table: "comments");

            migrationBuilder.DropForeignKey(
                name: "FK_comments_AspNetUsers_appUserId",
                table: "comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_comments",
                table: "comments");

            migrationBuilder.DropIndex(
                name: "IX_comments_animelerAnimeID",
                table: "comments");

            migrationBuilder.DropIndex(
                name: "IX_comments_appUserId",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "animelerAnimeID",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "appUserId",
                table: "comments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_comments",
                table: "comments",
                columns: new[] { "AnimeCommentID", "CommentID", "CommentUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_comments_CommentUserId",
                table: "comments",
                column: "CommentUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_Animelers_AnimeCommentID",
                table: "comments",
                column: "AnimeCommentID",
                principalTable: "Animelers",
                principalColumn: "AnimeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comments_AspNetUsers_CommentUserId",
                table: "comments",
                column: "CommentUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
