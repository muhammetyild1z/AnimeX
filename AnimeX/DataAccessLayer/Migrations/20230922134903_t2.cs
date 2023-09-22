using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class t2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_Animelers_animelerAnimeID",
                table: "comments");

            migrationBuilder.AlterColumn<int>(
                name: "animelerAnimeID",
                table: "comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_Animelers_animelerAnimeID",
                table: "comments",
                column: "animelerAnimeID",
                principalTable: "Animelers",
                principalColumn: "AnimeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_Animelers_animelerAnimeID",
                table: "comments");

            migrationBuilder.AlterColumn<int>(
                name: "animelerAnimeID",
                table: "comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_comments_Animelers_animelerAnimeID",
                table: "comments",
                column: "animelerAnimeID",
                principalTable: "Animelers",
                principalColumn: "AnimeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
