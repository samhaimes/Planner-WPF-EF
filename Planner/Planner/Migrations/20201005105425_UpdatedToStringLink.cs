using Microsoft.EntityFrameworkCore.Migrations;

namespace Planner.Migrations
{
    public partial class UpdatedToStringLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActivitiesId",
                table: "Links",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DayId",
                table: "Links",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FamilyMemberId",
                table: "Links",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Links_ActivitiesId",
                table: "Links",
                column: "ActivitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_DayId",
                table: "Links",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_FamilyMemberId",
                table: "Links",
                column: "FamilyMemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Links_GetActivities_ActivitiesId",
                table: "Links",
                column: "ActivitiesId",
                principalTable: "GetActivities",
                principalColumn: "ActivitiesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_Days_DayId",
                table: "Links",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "DayId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_FamilyMembers_FamilyMemberId",
                table: "Links",
                column: "FamilyMemberId",
                principalTable: "FamilyMembers",
                principalColumn: "FamilyMemberId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_GetActivities_ActivitiesId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_Days_DayId",
                table: "Links");

            migrationBuilder.DropForeignKey(
                name: "FK_Links_FamilyMembers_FamilyMemberId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_ActivitiesId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_DayId",
                table: "Links");

            migrationBuilder.DropIndex(
                name: "IX_Links_FamilyMemberId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "ActivitiesId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "DayId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "FamilyMemberId",
                table: "Links");
        }
    }
}
