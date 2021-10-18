using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPowerData.Migrations
{
    public partial class LoginModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BasicWorkoutInformation",
                table: "BasicWorkoutInformation");

            migrationBuilder.RenameTable(
                name: "BasicWorkoutInformation",
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
                newName: "BasicWorkoutInformation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasicWorkoutInformation",
                table: "BasicWorkoutInformation",
                column: "Id");
        }
    }
}
