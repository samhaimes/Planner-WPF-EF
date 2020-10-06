using Microsoft.EntityFrameworkCore.Migrations;

namespace Planner.Migrations
{
    public partial class UpdatedPropertyNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_FamilyMembers_FamilyMemberId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "_dayofweek",
                table: "Days");

            migrationBuilder.AlterColumn<int>(
                name: "FamilyMemberId",
                table: "Links",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "FamilyMembers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "FamilyMembers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stage",
                table: "FamilyMembers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DayOfWeek",
                table: "Days",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_FamilyMembers_FamilyMemberId",
                table: "Links",
                column: "FamilyMemberId",
                principalTable: "FamilyMembers",
                principalColumn: "FamilyMemberId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Links_FamilyMembers_FamilyMemberId",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "FamilyMembers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "FamilyMembers");

            migrationBuilder.DropColumn(
                name: "Stage",
                table: "FamilyMembers");

            migrationBuilder.DropColumn(
                name: "DayOfWeek",
                table: "Days");

            migrationBuilder.AlterColumn<int>(
                name: "FamilyMemberId",
                table: "Links",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_dayofweek",
                table: "Days",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Links_FamilyMembers_FamilyMemberId",
                table: "Links",
                column: "FamilyMemberId",
                principalTable: "FamilyMembers",
                principalColumn: "FamilyMemberId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
