using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class userFavTblUp_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userFavoris_Animelers_AnimelerAnimeID",
                table: "userFavoris");

            migrationBuilder.RenameColumn(
                name: "AnimelerAnimeID",
                table: "userFavoris",
                newName: "AnimelersAnimeID");

            migrationBuilder.RenameIndex(
                name: "IX_userFavoris_AnimelerAnimeID",
                table: "userFavoris",
                newName: "IX_userFavoris_AnimelersAnimeID");

            migrationBuilder.AddForeignKey(
                name: "FK_userFavoris_Animelers_AnimelersAnimeID",
                table: "userFavoris",
                column: "AnimelersAnimeID",
                principalTable: "Animelers",
                principalColumn: "AnimeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userFavoris_Animelers_AnimelersAnimeID",
                table: "userFavoris");

            migrationBuilder.RenameColumn(
                name: "AnimelersAnimeID",
                table: "userFavoris",
                newName: "AnimelerAnimeID");

            migrationBuilder.RenameIndex(
                name: "IX_userFavoris_AnimelersAnimeID",
                table: "userFavoris",
                newName: "IX_userFavoris_AnimelerAnimeID");

            migrationBuilder.AddForeignKey(
                name: "FK_userFavoris_Animelers_AnimelerAnimeID",
                table: "userFavoris",
                column: "AnimelerAnimeID",
                principalTable: "Animelers",
                principalColumn: "AnimeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
