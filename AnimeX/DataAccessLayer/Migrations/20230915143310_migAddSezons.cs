using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class migAddSezons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnimeSezon",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sezonlar = table.Column<int>(type: "int", nullable: false),
                    Bolumler = table.Column<int>(type: "int", nullable: false),
                    SezonIzlekapakImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SezonIzleUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeSezon", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AnimeSezon_Animelers_AnimeID",
                        column: x => x.AnimeID,
                        principalTable: "Animelers",
                        principalColumn: "AnimeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimeSezon_AnimeID",
                table: "AnimeSezon",
                column: "AnimeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimeSezon");
        }
    }
}
