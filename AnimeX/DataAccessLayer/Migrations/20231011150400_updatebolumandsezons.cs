using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class updatebolumandsezons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_animeSezonlars_animeBolumlers_BolumAnimelerBolumId",
                table: "animeSezonlars");

            migrationBuilder.DropIndex(
                name: "IX_animeSezonlars_BolumAnimelerBolumId",
                table: "animeSezonlars");

            migrationBuilder.DropColumn(
                name: "BolumAnimelerBolumId",
                table: "animeSezonlars");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BolumAnimelerBolumId",
                table: "animeSezonlars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_animeSezonlars_BolumAnimelerBolumId",
                table: "animeSezonlars",
                column: "BolumAnimelerBolumId");

            migrationBuilder.AddForeignKey(
                name: "FK_animeSezonlars_animeBolumlers_BolumAnimelerBolumId",
                table: "animeSezonlars",
                column: "BolumAnimelerBolumId",
                principalTable: "animeBolumlers",
                principalColumn: "AnimelerBolumId");
        }
    }
}
