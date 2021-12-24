using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPowerData.Migrations
{
    public partial class Initi1234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "A2SWorkoutExercises");

            migrationBuilder.DropTable(
                name: "A2SWorkoutTemplate");

            migrationBuilder.AddColumn<int>(
                name: "A2SHyperTrophy_Week",
                table: "BasicWorkoutInformation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AmrapRepResult",
                table: "BasicWorkoutInformation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AmrapRepTarget",
                table: "BasicWorkoutInformation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AuxillaryLift",
                table: "BasicWorkoutInformation",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Block",
                table: "BasicWorkoutInformation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "BasicWorkoutInformation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GoalReps",
                table: "BasicWorkoutInformation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GoalSets",
                table: "BasicWorkoutInformation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Intensity",
                table: "BasicWorkoutInformation",
                type: "decimal(9,4)",
                precision: 9,
                scale: 4,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RepIncreasePerSet",
                table: "BasicWorkoutInformation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RepsPerSet",
                table: "BasicWorkoutInformation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "RoundingValue",
                table: "BasicWorkoutInformation",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sets",
                table: "BasicWorkoutInformation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StartingReps",
                table: "BasicWorkoutInformation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StartingSets",
                table: "BasicWorkoutInformation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "StartingWeight",
                table: "BasicWorkoutInformation",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TrainingMax",
                table: "BasicWorkoutInformation",
                type: "decimal(9,4)",
                precision: 9,
                scale: 4,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Week",
                table: "BasicWorkoutInformation",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "A2SHyperTrophy_Week",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "AmrapRepResult",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "AmrapRepTarget",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "AuxillaryLift",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "Block",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "GoalReps",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "GoalSets",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "Intensity",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "RepIncreasePerSet",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "RepsPerSet",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "RoundingValue",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "Sets",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "StartingReps",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "StartingSets",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "StartingWeight",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "TrainingMax",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "Week",
                table: "BasicWorkoutInformation");

            migrationBuilder.CreateTable(
                name: "A2SWorkoutExercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmrapRepResult = table.Column<int>(type: "int", nullable: false),
                    AmrapRepTarget = table.Column<int>(type: "int", nullable: false),
                    AuxillaryLift = table.Column<bool>(type: "bit", nullable: false),
                    Block = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Intensity = table.Column<decimal>(type: "decimal(9,4)", precision: 9, scale: 4, nullable: false),
                    RepsPerSet = table.Column<int>(type: "int", nullable: false),
                    RoundingValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    TrainingMax = table.Column<decimal>(type: "decimal(9,4)", precision: 9, scale: 4, nullable: false),
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Week = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A2SWorkoutExercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "A2SWorkoutTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoalReps = table.Column<int>(type: "int", nullable: false),
                    GoalSets = table.Column<int>(type: "int", nullable: false),
                    RepIncreasePerSet = table.Column<int>(type: "int", nullable: false),
                    StartingReps = table.Column<int>(type: "int", nullable: false),
                    StartingSets = table.Column<int>(type: "int", nullable: false),
                    StartingWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Week = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A2SWorkoutTemplate", x => x.Id);
                });
        }
    }
}
