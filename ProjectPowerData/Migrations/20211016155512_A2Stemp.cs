using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPowerData.Migrations
{
    public partial class A2Stemp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "A2SWorkoutTemplate",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuxillaryLift = table.Column<bool>(type: "bit", nullable: false),
                    Block = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmrapRepTarget = table.Column<int>(type: "int", nullable: false),
                    Week = table.Column<int>(type: "int", nullable: false),
                    Intensity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    RepsPerSet = table.Column<int>(type: "int", nullable: false),
                    BeatByOne = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeatByTwo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeatByThree = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeatByFour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeatByFive = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MatchedTarget = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnderByOne = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnderByTwo = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A2SWorkoutTemplate", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "A2SWorkoutTemplate");
        }
    }
}
