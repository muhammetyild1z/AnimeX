using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class updateSezonsTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BolumNo",
                table: "animeSezonlars",
                newName: "SezonNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SezonNo",
                table: "animeSezonlars",
                newName: "BolumNo");
        }
    }
}
