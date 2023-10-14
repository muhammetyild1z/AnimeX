using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeX.DataAccessLayer.Migrations
{
    public partial class bolumcreatedateadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BolumCreateDate",
                table: "animeBolumlers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BolumCreateDate",
                table: "animeBolumlers");
        }
    }
}
