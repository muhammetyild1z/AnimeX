using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class updateBolumlerTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SezonsNo",
                table: "animeBolumlers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SezonsNo",
                table: "animeBolumlers");
        }
    }
}
