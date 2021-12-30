using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPowerData.Migrations
{
    public partial class ntf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "BasicWorkoutInformation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Discriminator",
                table: "BasicWorkoutInformation",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
