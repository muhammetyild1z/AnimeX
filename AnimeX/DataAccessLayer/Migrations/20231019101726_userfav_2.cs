using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class userfav_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userFavoris_Animelers_AnimelersAnimeID",
                table: "userFavoris");

            migrationBuilder.DropForeignKey(
                name: "FK_userFavoris_AspNetUsers_AppUserId",
                table: "userFavoris");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "userFavoris",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AnimelersAnimeID",
                table: "userFavoris",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_userFavoris_Animelers_AnimelersAnimeID",
                table: "userFavoris",
                column: "AnimelersAnimeID",
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
                name: "FK_userFavoris_Animelers_AnimelersAnimeID",
                table: "userFavoris");

            migrationBuilder.DropForeignKey(
                name: "FK_userFavoris_AspNetUsers_AppUserId",
                table: "userFavoris");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "userFavoris",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AnimelersAnimeID",
                table: "userFavoris",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_userFavoris_Animelers_AnimelersAnimeID",
                table: "userFavoris",
                column: "AnimelersAnimeID",
                principalTable: "Animelers",
                principalColumn: "AnimeID");

            migrationBuilder.AddForeignKey(
                name: "FK_userFavoris_AspNetUsers_AppUserId",
                table: "userFavoris",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
