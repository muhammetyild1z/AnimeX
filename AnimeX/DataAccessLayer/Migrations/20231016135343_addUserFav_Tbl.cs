using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class addUserFav_Tbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "userFavoris",
                columns: table => new
                {
                    UserFavoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFavAnimeID = table.Column<int>(type: "int", nullable: false),
                    UserFavUserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userFavoris", x => x.UserFavoriID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animelers_userFavoris_UserFavoriID",
                table: "Animelers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_userFavoris_UserFavoriID",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "userFavoris");

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
        }
    }
}
