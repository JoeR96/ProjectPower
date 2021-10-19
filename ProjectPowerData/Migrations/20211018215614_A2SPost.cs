using Microsoft.EntityFrameworkCore.Migrations;
namespace ProjectPowerData.Migrations
{
    public partial class A2SPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "UserAccounts",
                newName: "UserName");

            migrationBuilder.AlterColumn<decimal>(
                name: "TrainingMax",
                table: "A2SWorkoutExercises",
                type: "decimal(9,4)",
                precision: 9,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Intensity",
                table: "A2SWorkoutExercises",
                type: "decimal(9,4)",
                precision: 9,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "UserAccounts",
                newName: "Username");

            migrationBuilder.AlterColumn<decimal>(
                name: "TrainingMax",
                table: "A2SWorkoutExercises",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,4)",
                oldPrecision: 9,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Intensity",
                table: "A2SWorkoutExercises",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,4)",
                oldPrecision: 9,
                oldScale: 4);
        }
    }
}
