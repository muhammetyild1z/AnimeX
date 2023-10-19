using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class userFavTblUp_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userFavoris_Animelers_animeAnimeIDAnimeID",
                table: "userFavoris");

            migrationBuilder.DropForeignKey(
                name: "FK_userFavoris_AspNetUsers_userIdId",
                table: "userFavoris");

            migrationBuilder.DropIndex(
                name: "IX_userFavoris_animeAnimeIDAnimeID",
                table: "userFavoris");

            migrationBuilder.DropIndex(
                name: "IX_userFavoris_userIdId",
                table: "userFavoris");

            migrationBuilder.RenameColumn(
                name: "userIdId",
                table: "userFavoris",
                newName: "FavUserId");

            migrationBuilder.RenameColumn(
                name: "animeAnimeIDAnimeID",
                table: "userFavoris",
                newName: "FavAnimeID");

            migrationBuilder.AddColumn<int>(
                name: "AnimelerAnimeID",
                table: "userFavoris",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "userFavoris",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                principalColumn: "AnimeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userFavoris_AspNetUsers_AppUserId",
                table: "userFavoris",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.RenameColumn(
                name: "FavUserId",
                table: "userFavoris",
                newName: "userIdId");

            migrationBuilder.RenameColumn(
                name: "FavAnimeID",
                table: "userFavoris",
                newName: "animeAnimeIDAnimeID");

            migrationBuilder.CreateIndex(
                name: "IX_userFavoris_animeAnimeIDAnimeID",
                table: "userFavoris",
                column: "animeAnimeIDAnimeID");

            migrationBuilder.CreateIndex(
                name: "IX_userFavoris_userIdId",
                table: "userFavoris",
                column: "userIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_userFavoris_Animelers_animeAnimeIDAnimeID",
                table: "userFavoris",
                column: "animeAnimeIDAnimeID",
                principalTable: "Animelers",
                principalColumn: "AnimeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userFavoris_AspNetUsers_userIdId",
                table: "userFavoris",
                column: "userIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
