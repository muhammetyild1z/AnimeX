using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class userfavoriKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userFavoris_Animelers_AnimelerAnimeID",
                table: "userFavoris");

            migrationBuilder.DropForeignKey(
                name: "FK_userFavoris_AspNetUsers_AppUserId",
                table: "userFavoris");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "userFavoris",
                newName: "appUserId");

            migrationBuilder.RenameColumn(
                name: "AnimelerAnimeID",
                table: "userFavoris",
                newName: "animelerAnimeID");

            migrationBuilder.RenameIndex(
                name: "IX_userFavoris_AppUserId",
                table: "userFavoris",
                newName: "IX_userFavoris_appUserId");

            migrationBuilder.RenameIndex(
                name: "IX_userFavoris_AnimelerAnimeID",
                table: "userFavoris",
                newName: "IX_userFavoris_animelerAnimeID");

            migrationBuilder.AlterColumn<int>(
                name: "appUserId",
                table: "userFavoris",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "animelerAnimeID",
                table: "userFavoris",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userFavoris_Animelers_animelerAnimeID",
                table: "userFavoris");

            migrationBuilder.DropForeignKey(
                name: "FK_userFavoris_AspNetUsers_appUserId",
                table: "userFavoris");

            migrationBuilder.RenameColumn(
                name: "appUserId",
                table: "userFavoris",
                newName: "AppUserId");

            migrationBuilder.RenameColumn(
                name: "animelerAnimeID",
                table: "userFavoris",
                newName: "AnimelerAnimeID");

            migrationBuilder.RenameIndex(
                name: "IX_userFavoris_appUserId",
                table: "userFavoris",
                newName: "IX_userFavoris_AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_userFavoris_animelerAnimeID",
                table: "userFavoris",
                newName: "IX_userFavoris_AnimelerAnimeID");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "userFavoris",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AnimelerAnimeID",
                table: "userFavoris",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
