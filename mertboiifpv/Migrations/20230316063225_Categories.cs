using Microsoft.EntityFrameworkCore.Migrations;

namespace mertboiifpv.Migrations
{
    public partial class Categories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DroneCategory",
                table: "PavoDrones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DroneCategory",
                table: "MeteorDrones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BatteryCellCount",
                table: "Batteries",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DroneCategory",
                table: "PavoDrones");

            migrationBuilder.DropColumn(
                name: "DroneCategory",
                table: "MeteorDrones");

            migrationBuilder.DropColumn(
                name: "BatteryCellCount",
                table: "Batteries");
        }
    }
}
