using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class intihinalCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriesCategoryAnime");

            migrationBuilder.AddColumn<int>(
                name: "CategoryAnimeID",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryAnimeID",
                table: "Categories",
                column: "CategoryAnimeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_CategoryAnimes_CategoryAnimeID",
                table: "Categories",
                column: "CategoryAnimeID",
                principalTable: "CategoryAnimes",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_CategoryAnimes_CategoryAnimeID",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryAnimeID",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryAnimeID",
                table: "Categories");

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
                name: "IX_CategoriesCategoryAnime_categoryAnimesID",
                table: "CategoriesCategoryAnime",
                column: "categoryAnimesID");
        }
    }
}
