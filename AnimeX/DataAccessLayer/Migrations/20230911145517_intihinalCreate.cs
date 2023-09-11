using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class intihinalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryAnimes", x => x.ID);
                });

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
                    AnimeCikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryAnimeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animelers", x => x.AnimeID);
                    table.ForeignKey(
                        name: "FK_Animelers_CategoryAnimes_CategoryAnimeID",
                        column: x => x.CategoryAnimeID,
                        principalTable: "CategoryAnimes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CategoriesCategoryAnime",
                columns: table => new
                {
                    categorieskategoriID = table.Column<int>(type: "int", nullable: false),
                    categoryAnimesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesCategoryAnime", x => new { x.categorieskategoriID, x.categoryAnimesID });
                    table.ForeignKey(
                        name: "FK_CategoriesCategoryAnime_Categories_categorieskategoriID",
                        column: x => x.categorieskategoriID,
                        principalTable: "Categories",
                        principalColumn: "kategoriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriesCategoryAnime_CategoryAnimes_categoryAnimesID",
                        column: x => x.categoryAnimesID,
                        principalTable: "CategoryAnimes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animelers_CategoryAnimeID",
                table: "Animelers",
                column: "CategoryAnimeID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesCategoryAnime_categoryAnimesID",
                table: "CategoriesCategoryAnime",
                column: "categoryAnimesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animelers");

            migrationBuilder.DropTable(
                name: "CategoriesCategoryAnime");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CategoryAnimes");
        }
    }
}
