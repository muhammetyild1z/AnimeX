using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class userFavTblUp_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userFavoris_Animelers_animelerAnimeID",
                table: "userFavoris");

            migrationBuilder.DropForeignKey(
                name: "FK_userFavoris_AspNetUsers_appUserId",
                table: "userFavoris");

            migrationBuilder.DropColumn(
                name: "AnimeID",
                table: "userFavoris");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "userFavoris");

            migrationBuilder.RenameColumn(
                name: "appUserId",
                table: "userFavoris",
                newName: "userIdId");

            migrationBuilder.RenameColumn(
                name: "animelerAnimeID",
                table: "userFavoris",
                newName: "animeAnimeIDAnimeID");

            migrationBuilder.RenameIndex(
                name: "IX_userFavoris_appUserId",
                table: "userFavoris",
                newName: "IX_userFavoris_userIdId");

            migrationBuilder.RenameIndex(
                name: "IX_userFavoris_animelerAnimeID",
                table: "userFavoris",
                newName: "IX_userFavoris_animeAnimeIDAnimeID");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userFavoris_Animelers_animeAnimeIDAnimeID",
                table: "userFavoris");

            migrationBuilder.DropForeignKey(
                name: "FK_userFavoris_AspNetUsers_userIdId",
                table: "userFavoris");

            migrationBuilder.RenameColumn(
                name: "userIdId",
                table: "userFavoris",
                newName: "appUserId");

            migrationBuilder.RenameColumn(
                name: "animeAnimeIDAnimeID",
                table: "userFavoris",
                newName: "animelerAnimeID");

            migrationBuilder.RenameIndex(
                name: "IX_userFavoris_userIdId",
                table: "userFavoris",
                newName: "IX_userFavoris_appUserId");

            migrationBuilder.RenameIndex(
                name: "IX_userFavoris_animeAnimeIDAnimeID",
                table: "userFavoris",
                newName: "IX_userFavoris_animelerAnimeID");

            migrationBuilder.AddColumn<int>(
                name: "AnimeID",
                table: "userFavoris",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "userFavoris",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_userFavoris_Animelers_animelerAnimeID",
                table: "userFavoris",
                column: "animelerAnimeID",
                principalTable: "Animelers",
                principalColumn: "AnimeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userFavoris_AspNetUsers_appUserId",
                table: "userFavoris",
                column: "appUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
