using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class upFavoriTblKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_userFavoris",
                table: "userFavoris");

            migrationBuilder.AlterColumn<int>(
                name: "UserFavoriID",
                table: "userFavoris",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userFavoris",
                table: "userFavoris",
                columns: new[] { "FavAnimeID", "FavUserId", "UserFavoriID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_userFavoris",
                table: "userFavoris");

            migrationBuilder.AlterColumn<int>(
                name: "UserFavoriID",
                table: "userFavoris",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userFavoris",
                table: "userFavoris",
                columns: new[] { "FavAnimeID", "FavUserId" });
        }
    }
}
