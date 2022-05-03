using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectPowerData.Migrations
{
    public partial class renew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_UserAccounts_UserAccountUserId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserAccountUserId",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "UserAccountUserId",
                table: "UserRoles");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_UserAccounts_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "UserAccounts",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_UserAccounts_UserId",
                table: "UserRoles");

            migrationBuilder.AddColumn<int>(
                name: "UserAccountUserId",
                table: "UserRoles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserAccountUserId",
                table: "UserRoles",
                column: "UserAccountUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_UserAccounts_UserAccountUserId",
                table: "UserRoles",
                column: "UserAccountUserId",
                principalTable: "UserAccounts",
                principalColumn: "UserId");
        }
    }
}
