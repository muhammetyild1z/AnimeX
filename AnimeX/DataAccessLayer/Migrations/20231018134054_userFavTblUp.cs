using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class userFavTblUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserFavUserID",
                table: "userFavoris",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserFavAnimeID",
                table: "userFavoris",
                newName: "AnimeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "userFavoris",
                newName: "UserFavUserID");

            migrationBuilder.RenameColumn(
                name: "AnimeID",
                table: "userFavoris",
                newName: "UserFavAnimeID");
        }
    }
}
