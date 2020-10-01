using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectModel.Migrations
{
    public partial class ModifyDays : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "_dayofweek",
                table: "Days",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_dayofweek",
                table: "Days");
        }
    }
}
