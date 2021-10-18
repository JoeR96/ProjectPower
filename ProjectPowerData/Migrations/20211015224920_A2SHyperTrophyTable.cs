using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPowerData.Migrations
{
    public partial class A2SHyperTrophyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAccount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkoutExerciseInformation",
                table: "WorkoutExerciseInformation");

            migrationBuilder.RenameTable(
                name: "WorkoutExerciseInformation",
                newName: "BasicWorkoutInformation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasicWorkoutInformation",
                table: "BasicWorkoutInformation",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "A2SWorkoutExercises",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainingMax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AuxillaryLift = table.Column<bool>(type: "bit", nullable: false),
                    Block = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmrapRepTarget = table.Column<int>(type: "int", nullable: false),
                    AmrapRepResult = table.Column<int>(type: "int", nullable: false),
                    Week = table.Column<int>(type: "int", nullable: false),
                    Intensity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    RepsPerSet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A2SWorkoutExercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "A2SWorkoutExercises");

            migrationBuilder.DropTable(
                name: "UserAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasicWorkoutInformation",
                table: "BasicWorkoutInformation");

            migrationBuilder.RenameTable(
                name: "BasicWorkoutInformation",
                newName: "WorkoutExerciseInformation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkoutExerciseInformation",
                table: "WorkoutExerciseInformation",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UserAccount",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccount", x => x.UserId);
                });
        }
    }
}
