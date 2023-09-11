using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animelers",
                columns: table => new
                {
                    AnimeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimeAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimeDetay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimeKisaDetay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimeUyarlamasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMDb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Like = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    AnimeEklenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AnimeCikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animelers", x => x.AnimeID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    kategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.kategoriID);
                });

            migrationBuilder.CreateTable(
                name: "CategoryAnimes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimeID = table.Column<int>(type: "int", nullable: false),
                    animelerAnimeID = table.Column<int>(type: "int", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    categorieskategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryAnimes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CategoryAnimes_Animelers_animelerAnimeID",
                        column: x => x.animelerAnimeID,
                        principalTable: "Animelers",
                        principalColumn: "AnimeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryAnimes_Categories_categorieskategoriID",
                        column: x => x.categorieskategoriID,
                        principalTable: "Categories",
                        principalColumn: "kategoriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAnimes_animelerAnimeID",
                table: "CategoryAnimes",
                column: "animelerAnimeID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAnimes_categorieskategoriID",
                table: "CategoryAnimes",
                column: "categorieskategoriID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryAnimes");

            migrationBuilder.DropTable(
                name: "Animelers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
