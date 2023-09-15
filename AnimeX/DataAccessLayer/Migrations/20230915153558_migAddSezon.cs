using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class migAddSezon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimeSezon_Animelers_AnimeID",
                table: "AnimeSezon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimeSezon",
                table: "AnimeSezon");

            migrationBuilder.RenameTable(
                name: "AnimeSezon",
                newName: "animeSezons");

            migrationBuilder.RenameIndex(
                name: "IX_AnimeSezon_AnimeID",
                table: "animeSezons",
                newName: "IX_animeSezons_AnimeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_animeSezons",
                table: "animeSezons",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_animeSezons_Animelers_AnimeID",
                table: "animeSezons",
                column: "AnimeID",
                principalTable: "Animelers",
                principalColumn: "AnimeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_animeSezons_Animelers_AnimeID",
                table: "animeSezons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_animeSezons",
                table: "animeSezons");

            migrationBuilder.RenameTable(
                name: "animeSezons",
                newName: "AnimeSezon");

            migrationBuilder.RenameIndex(
                name: "IX_animeSezons_AnimeID",
                table: "AnimeSezon",
                newName: "IX_AnimeSezon_AnimeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimeSezon",
                table: "AnimeSezon",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AnimeSezon_Animelers_AnimeID",
                table: "AnimeSezon",
                column: "AnimeID",
                principalTable: "Animelers",
                principalColumn: "AnimeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
