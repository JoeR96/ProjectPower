using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPowerData.Migrations
{
    public partial class reps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GoalReps",
                table: "A2SWorkoutTemplate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GoalSets",
                table: "A2SWorkoutTemplate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "StartingWeight",
                table: "A2SWorkoutTemplate",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoalReps",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropColumn(
                name: "GoalSets",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropColumn(
                name: "StartingWeight",
                table: "A2SWorkoutTemplate");
        }
    }
}
