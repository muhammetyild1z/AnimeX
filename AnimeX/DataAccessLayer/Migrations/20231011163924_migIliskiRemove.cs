using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class migIliskiRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_animeBolumlers_Animelers_AnimelersAnimeID",
                table: "animeBolumlers");

            migrationBuilder.DropIndex(
                name: "IX_animeBolumlers_AnimelersAnimeID",
                table: "animeBolumlers");

            migrationBuilder.DropColumn(
                name: "AnimelersAnimeID",
                table: "animeBolumlers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnimelersAnimeID",
                table: "animeBolumlers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_animeBolumlers_AnimelersAnimeID",
                table: "animeBolumlers",
                column: "AnimelersAnimeID");

            migrationBuilder.AddForeignKey(
                name: "FK_animeBolumlers_Animelers_AnimelersAnimeID",
                table: "animeBolumlers",
                column: "AnimelersAnimeID",
                principalTable: "Animelers",
                principalColumn: "AnimeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
