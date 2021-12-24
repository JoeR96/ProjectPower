using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPowerData.Migrations
{
    public partial class refactoredExerciseSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BasicWorkoutInformation",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_A2SWorkoutExercises",
                table: "A2SWorkoutExercises");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "PR",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "A2SWorkoutExercises");

            migrationBuilder.DropColumn(
                name: "LiftDay",
                table: "A2SWorkoutExercises");

            migrationBuilder.DropColumn(
                name: "LiftOrder",
                table: "A2SWorkoutExercises");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "A2SWorkoutExercises");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "A2SWorkoutExercises",
                newName: "Template");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "BasicWorkoutInformation",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ExerciseDay",
                table: "BasicWorkoutInformation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExerciseOrder",
                table: "BasicWorkoutInformation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Template",
                table: "BasicWorkoutInformation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UniqueId",
                table: "A2SWorkoutExercises",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasicWorkoutInformation",
                table: "BasicWorkoutInformation",
                column: "UniqueId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_A2SWorkoutExercises",
                table: "A2SWorkoutExercises",
                column: "UniqueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BasicWorkoutInformation",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_A2SWorkoutExercises",
                table: "A2SWorkoutExercises");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "ExerciseDay",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "ExerciseOrder",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "Template",
                table: "BasicWorkoutInformation");

            migrationBuilder.RenameColumn(
                name: "Template",
                table: "A2SWorkoutExercises",
                newName: "Username");

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "BasicWorkoutInformation",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<decimal>(
                name: "PR",
                table: "BasicWorkoutInformation",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "UniqueId",
                table: "A2SWorkoutExercises",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "A2SWorkoutExercises",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "LiftDay",
                table: "A2SWorkoutExercises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LiftOrder",
                table: "A2SWorkoutExercises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "A2SWorkoutExercises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasicWorkoutInformation",
                table: "BasicWorkoutInformation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_A2SWorkoutExercises",
                table: "A2SWorkoutExercises",
                column: "Id");
        }
    }
}
