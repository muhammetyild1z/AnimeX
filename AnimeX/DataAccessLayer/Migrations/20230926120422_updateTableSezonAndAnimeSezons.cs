using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class updateTableSezonAndAnimeSezons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnimeBolumID_SezonID",
                table: "sezons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sezon",
                table: "sezons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_sezons_AnimeBolumID_SezonID",
                table: "sezons",
                column: "AnimeBolumID_SezonID");

            migrationBuilder.AddForeignKey(
                name: "FK_sezons_animeSezons_AnimeBolumID_SezonID",
                table: "sezons",
                column: "AnimeBolumID_SezonID",
                principalTable: "animeSezons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sezons_animeSezons_AnimeBolumID_SezonID",
                table: "sezons");

            migrationBuilder.DropIndex(
                name: "IX_sezons_AnimeBolumID_SezonID",
                table: "sezons");

            migrationBuilder.DropColumn(
                name: "AnimeBolumID_SezonID",
                table: "sezons");

            migrationBuilder.DropColumn(
                name: "Sezon",
                table: "sezons");
        }
    }
}
