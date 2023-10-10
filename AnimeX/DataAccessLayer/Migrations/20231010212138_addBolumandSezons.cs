using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class addBolumandSezons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnimeBolumlerAnimelerBolumId",
                table: "Animelers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AnimeSezonlarAnimelerSezonId",
                table: "Animelers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "animeBolumlers",
                columns: table => new
                {
                    AnimelerBolumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BolumNo = table.Column<int>(type: "int", nullable: false),
                    AnimeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_animeBolumlers", x => x.AnimelerBolumId);
                });

            migrationBuilder.CreateTable(
                name: "animeSezonlars",
                columns: table => new
                {
                    AnimelerSezonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumNo = table.Column<int>(type: "int", nullable: false),
                    BolumAnimelerBolumId = table.Column<int>(type: "int", nullable: true),
                    AnimeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_animeSezonlars", x => x.AnimelerSezonId);
                    table.ForeignKey(
                        name: "FK_animeSezonlars_animeBolumlers_BolumAnimelerBolumId",
                        column: x => x.BolumAnimelerBolumId,
                        principalTable: "animeBolumlers",
                        principalColumn: "AnimelerBolumId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animelers_AnimeBolumlerAnimelerBolumId",
                table: "Animelers",
                column: "AnimeBolumlerAnimelerBolumId");

            migrationBuilder.CreateIndex(
                name: "IX_Animelers_AnimeSezonlarAnimelerSezonId",
                table: "Animelers",
                column: "AnimeSezonlarAnimelerSezonId");

            migrationBuilder.CreateIndex(
                name: "IX_animeSezonlars_BolumAnimelerBolumId",
                table: "animeSezonlars",
                column: "BolumAnimelerBolumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animelers_animeBolumlers_AnimeBolumlerAnimelerBolumId",
                table: "Animelers",
                column: "AnimeBolumlerAnimelerBolumId",
                principalTable: "animeBolumlers",
                principalColumn: "AnimelerBolumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animelers_animeSezonlars_AnimeSezonlarAnimelerSezonId",
                table: "Animelers",
                column: "AnimeSezonlarAnimelerSezonId",
                principalTable: "animeSezonlars",
                principalColumn: "AnimelerSezonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animelers_animeBolumlers_AnimeBolumlerAnimelerBolumId",
                table: "Animelers");

            migrationBuilder.DropForeignKey(
                name: "FK_Animelers_animeSezonlars_AnimeSezonlarAnimelerSezonId",
                table: "Animelers");

            migrationBuilder.DropTable(
                name: "animeSezonlars");

            migrationBuilder.DropTable(
                name: "animeBolumlers");

            migrationBuilder.DropIndex(
                name: "IX_Animelers_AnimeBolumlerAnimelerBolumId",
                table: "Animelers");

            migrationBuilder.DropIndex(
                name: "IX_Animelers_AnimeSezonlarAnimelerSezonId",
                table: "Animelers");

            migrationBuilder.DropColumn(
                name: "AnimeBolumlerAnimelerBolumId",
                table: "Animelers");

            migrationBuilder.DropColumn(
                name: "AnimeSezonlarAnimelerSezonId",
                table: "Animelers");
        }
    }
}
