using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPowerData.Migrations
{
    public partial class turd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_A2SHyperTrophy",
                table: "A2SHyperTrophy");

            migrationBuilder.RenameTable(
                name: "A2SHyperTrophy",
                newName: "BasicWorkoutInformation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasicWorkoutInformation",
                table: "BasicWorkoutInformation",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BasicWorkoutInformation",
                table: "BasicWorkoutInformation");

            migrationBuilder.RenameTable(
                name: "BasicWorkoutInformation",
                newName: "A2SHyperTrophy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_A2SHyperTrophy",
                table: "A2SHyperTrophy",
                column: "Id");
        }
    }
}
