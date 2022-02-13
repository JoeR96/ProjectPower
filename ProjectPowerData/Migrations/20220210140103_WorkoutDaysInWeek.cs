using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPowerData.Migrations
{
    public partial class WorkoutDaysInWeek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Race",
                table: "UserAccounts");

            migrationBuilder.AddColumn<int>(
                name: "WorkoutDaysInWeek",
                table: "UserAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkoutWeeks",
                table: "UserAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkoutDaysInWeek",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "WorkoutWeeks",
                table: "UserAccounts");

            migrationBuilder.AddColumn<string>(
                name: "Race",
                table: "UserAccounts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
