using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class sezonstableadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnimeKapakImg",
                table: "Animelers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "sezons",
                columns: table => new
                {
                    SezonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumID = table.Column<int>(type: "int", nullable: false),
                    AnimeBolumID_SezonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sezons", x => x.SezonID);
                    table.ForeignKey(
                        name: "FK_sezons_animeSezons_AnimeBolumID_SezonID",
                        column: x => x.AnimeBolumID_SezonID,
                        principalTable: "animeSezons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sezons_AnimeBolumID_SezonID",
                table: "sezons",
                column: "AnimeBolumID_SezonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sezons");

            migrationBuilder.DropColumn(
                name: "AnimeKapakImg",
                table: "Animelers");
        }
    }
}
