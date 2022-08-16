using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPowerData.Migrations
{
    public partial class UniqueExerciseId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasicWorkoutInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseDay = table.Column<int>(type: "int", nullable: false),
                    ExerciseOrder = table.Column<int>(type: "int", nullable: false),
                    Template = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Week = table.Column<int>(type: "int", nullable: false),
                    ExerciseMasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExerciseCompleted = table.Column<bool>(type: "bit", nullable: true),
                    ExerciseTargetCompleted = table.Column<bool>(type: "bit", nullable: true),
                    TrainingMax = table.Column<decimal>(type: "decimal(9,4)", precision: 9, scale: 4, nullable: true),
                    AuxillaryLift = table.Column<bool>(type: "bit", nullable: true),
                    Block = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmrapRepTarget = table.Column<int>(type: "int", nullable: true),
                    AmrapRepResult = table.Column<int>(type: "int", nullable: true),
                    Intensity = table.Column<decimal>(type: "decimal(9,4)", precision: 9, scale: 4, nullable: true),
                    Sets = table.Column<int>(type: "int", nullable: true),
                    RepsPerSet = table.Column<int>(type: "int", nullable: true),
                    RoundingValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StartingReps = table.Column<int>(type: "int", nullable: true),
                    StartingSets = table.Column<int>(type: "int", nullable: true),
                    RepIncreasePerSet = table.Column<int>(type: "int", nullable: true),
                    CurrentReps = table.Column<int>(type: "int", nullable: true),
                    CurrentSets = table.Column<int>(type: "int", nullable: true),
                    GoalSets = table.Column<int>(type: "int", nullable: true),
                    GoalReps = table.Column<int>(type: "int", nullable: true),
                    StartingWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicWorkoutInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentWeek = table.Column<int>(type: "int", nullable: false),
                    CurrentDay = table.Column<int>(type: "int", nullable: false),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasicWorkoutInformation");

            migrationBuilder.DropTable(
                name: "UserAccounts");
        }
    }
}
