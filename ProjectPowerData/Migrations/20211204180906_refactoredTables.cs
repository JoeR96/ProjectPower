using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPowerData.Migrations
{
    public partial class refactoredTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_A2SWorkoutTemplate",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropColumn(
                name: "AmrapRepTarget",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropColumn(
                name: "AuxillaryLift",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropColumn(
                name: "BeatByFive",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropColumn(
                name: "BeatByFour",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropColumn(
                name: "BeatByOne",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropColumn(
                name: "BeatByThree",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropColumn(
                name: "BeatByTwo",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropColumn(
                name: "Block",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropColumn(
                name: "Intensity",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropColumn(
                name: "MatchedTarget",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropColumn(
                name: "UnderByOne",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropColumn(
                name: "UnderByTwo",
                table: "A2SWorkoutTemplate");

            migrationBuilder.RenameColumn(
                name: "Week",
                table: "A2SWorkoutTemplate",
                newName: "StartingSets");

            migrationBuilder.RenameColumn(
                name: "Sets",
                table: "A2SWorkoutTemplate",
                newName: "StartingReps");

            migrationBuilder.RenameColumn(
                name: "RepsPerSet",
                table: "A2SWorkoutTemplate",
                newName: "RepIncreasePerSet");

            migrationBuilder.AddColumn<string>(
                name: "UniqueId",
                table: "A2SWorkoutTemplate",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_A2SWorkoutTemplate",
                table: "A2SWorkoutTemplate",
                column: "UniqueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_A2SWorkoutTemplate",
                table: "A2SWorkoutTemplate");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "A2SWorkoutTemplate");

            migrationBuilder.RenameColumn(
                name: "StartingSets",
                table: "A2SWorkoutTemplate",
                newName: "Week");

            migrationBuilder.RenameColumn(
                name: "StartingReps",
                table: "A2SWorkoutTemplate",
                newName: "Sets");

            migrationBuilder.RenameColumn(
                name: "RepIncreasePerSet",
                table: "A2SWorkoutTemplate",
                newName: "RepsPerSet");

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "A2SWorkoutTemplate",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AmrapRepTarget",
                table: "A2SWorkoutTemplate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AuxillaryLift",
                table: "A2SWorkoutTemplate",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "BeatByFive",
                table: "A2SWorkoutTemplate",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BeatByFour",
                table: "A2SWorkoutTemplate",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BeatByOne",
                table: "A2SWorkoutTemplate",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BeatByThree",
                table: "A2SWorkoutTemplate",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "BeatByTwo",
                table: "A2SWorkoutTemplate",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Block",
                table: "A2SWorkoutTemplate",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Intensity",
                table: "A2SWorkoutTemplate",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MatchedTarget",
                table: "A2SWorkoutTemplate",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "A2SWorkoutTemplate",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "UnderByOne",
                table: "A2SWorkoutTemplate",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "UnderByTwo",
                table: "A2SWorkoutTemplate",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_A2SWorkoutTemplate",
                table: "A2SWorkoutTemplate",
                column: "Id");
        }
    }
}
