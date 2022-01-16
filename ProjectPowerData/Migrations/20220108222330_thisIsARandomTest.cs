using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPowerData.Migrations
{
    public partial class thisIsARandomTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TemplateValuesId",
                table: "BasicWorkoutInformation",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BasicWorkoutInformation_TemplateValuesId",
                table: "BasicWorkoutInformation",
                column: "TemplateValuesId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasicWorkoutInformation_BasicWorkoutInformation_TemplateValuesId",
                table: "BasicWorkoutInformation",
                column: "TemplateValuesId",
                principalTable: "BasicWorkoutInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasicWorkoutInformation_BasicWorkoutInformation_TemplateValuesId",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropIndex(
                name: "IX_BasicWorkoutInformation_TemplateValuesId",
                table: "BasicWorkoutInformation");

            migrationBuilder.DropColumn(
                name: "TemplateValuesId",
                table: "BasicWorkoutInformation");
        }
    }
}
