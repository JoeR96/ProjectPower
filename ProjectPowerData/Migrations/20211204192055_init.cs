using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPowerData.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BasicWorkoutInformation",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_A2SWorkoutTemplate",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_A2SWorkoutExercises",
                table: "A2SWorkoutExercises");

            migrationBuilder.AlterColumn<string>(
                name: "UniqueId",
                table: "BasicWorkoutInformation",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BasicWorkoutInformation",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "UniqueId",
                table: "A2SWorkoutTemplate",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "A2SWorkoutTemplate",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "UniqueId",
                table: "A2SWorkoutExercises",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "A2SWorkoutExercises",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasicWorkoutInformation",
                table: "BasicWorkoutInformation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_A2SWorkoutTemplate",
                table: "A2SWorkoutTemplate",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_A2SWorkoutExercises",
                table: "A2SWorkoutExercises",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BasicWorkoutInformation",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_A2SWorkoutTemplate",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_A2SWorkoutExercises",
                table: "A2SWorkoutExercises");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "A2SWorkoutExercises");

            migrationBuilder.AlterColumn<string>(
                name: "UniqueId",
                table: "BasicWorkoutInformation",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UniqueId",
                table: "A2SWorkoutTemplate",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                name: "PK_A2SWorkoutTemplate",
                table: "A2SWorkoutTemplate",
                column: "UniqueId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_A2SWorkoutExercises",
                table: "A2SWorkoutExercises",
                column: "UniqueId");
        }
    }
}
