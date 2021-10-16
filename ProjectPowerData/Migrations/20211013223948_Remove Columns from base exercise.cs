using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPowerData.Migrations
{
    public partial class RemoveColumnsfrombaseexercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuxillaryLift",
                table: "WorkoutExerciseInformation");

            migrationBuilder.DropColumn(
                name: "Block",
                table: "WorkoutExerciseInformation");

            migrationBuilder.DropColumn(
                name: "TrainingMax",
                table: "WorkoutExerciseInformation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AuxillaryLift",
                table: "WorkoutExerciseInformation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Block",
                table: "WorkoutExerciseInformation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TrainingMax",
                table: "WorkoutExerciseInformation",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
