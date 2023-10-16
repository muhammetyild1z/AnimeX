using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class updateFacUserTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animelers_userFavoris_UserFavoriID",
                table: "Animelers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_userFavoris_UserFavoriID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserFavoriID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_Animelers_UserFavoriID",
                table: "Animelers");

            migrationBuilder.DropColumn(
                name: "UserFavoriID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserFavoriID",
                table: "Animelers");

            migrationBuilder.AddColumn<int>(
                name: "AnimelerAnimeID",
                table: "userFavoris",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "userFavoris",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_userFavoris_AnimelerAnimeID",
                table: "userFavoris",
                column: "AnimelerAnimeID");

            migrationBuilder.CreateIndex(
                name: "IX_userFavoris_AppUserId",
                table: "userFavoris",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_userFavoris_Animelers_AnimelerAnimeID",
                table: "userFavoris",
                column: "AnimelerAnimeID",
                principalTable: "Animelers",
                principalColumn: "AnimeID");

            migrationBuilder.AddForeignKey(
                name: "FK_userFavoris_AspNetUsers_AppUserId",
                table: "userFavoris",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userFavoris_Animelers_AnimelerAnimeID",
                table: "userFavoris");

            migrationBuilder.DropForeignKey(
                name: "FK_userFavoris_AspNetUsers_AppUserId",
                table: "userFavoris");

            migrationBuilder.DropIndex(
                name: "IX_userFavoris_AnimelerAnimeID",
                table: "userFavoris");

            migrationBuilder.DropIndex(
                name: "IX_userFavoris_AppUserId",
                table: "userFavoris");

            migrationBuilder.DropColumn(
                name: "AnimelerAnimeID",
                table: "userFavoris");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "userFavoris");

            migrationBuilder.AddColumn<int>(
                name: "UserFavoriID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserFavoriID",
                table: "Animelers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserFavoriID",
                table: "AspNetUsers",
                column: "UserFavoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Animelers_UserFavoriID",
                table: "Animelers",
                column: "UserFavoriID");

            migrationBuilder.AddForeignKey(
                name: "FK_Animelers_userFavoris_UserFavoriID",
                table: "Animelers",
                column: "UserFavoriID",
                principalTable: "userFavoris",
                principalColumn: "UserFavoriID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_userFavoris_UserFavoriID",
                table: "AspNetUsers",
                column: "UserFavoriID",
                principalTable: "userFavoris",
                principalColumn: "UserFavoriID");
        }
    }
}
