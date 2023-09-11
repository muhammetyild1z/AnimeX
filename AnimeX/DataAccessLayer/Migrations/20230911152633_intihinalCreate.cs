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
                    AnimeID1 = table.Column<int>(type: "int", nullable: false),
                    kategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryAnimes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CategoryAnimes_Animelers_AnimeID1",
                        column: x => x.AnimeID1,
                        principalTable: "Animelers",
                        principalColumn: "AnimeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryAnimes_Categories_kategoriID",
                        column: x => x.kategoriID,
                        principalTable: "Categories",
                        principalColumn: "kategoriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAnimes_AnimeID1",
                table: "CategoryAnimes",
                column: "AnimeID1");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAnimes_kategoriID",
                table: "CategoryAnimes",
                column: "kategoriID");
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
