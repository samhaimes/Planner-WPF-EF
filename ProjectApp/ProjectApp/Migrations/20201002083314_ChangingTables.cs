using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectModel.Migrations
{
    public partial class ChangingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FamilyMembers",
                columns: table => new
                {
                    FamilyMemberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyMembers", x => x.FamilyMemberId);
                });

            migrationBuilder.CreateTable(
                name: "GetActivities",
                columns: table => new
                {
                    ActivitiesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activity = table.Column<string>(nullable: true),
                    ActivityDetails = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetActivities", x => x.ActivitiesId);
                });

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    DayId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _dayofweek = table.Column<string>(nullable: true),
                    ActivitiesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.DayId);
                    table.ForeignKey(
                        name: "FK_Days_GetActivities_ActivitiesId",
                        column: x => x.ActivitiesId,
                        principalTable: "GetActivities",
                        principalColumn: "ActivitiesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Days_ActivitiesId",
                table: "Days",
                column: "ActivitiesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "FamilyMembers");

            migrationBuilder.DropTable(
                name: "GetActivities");
        }
    }
}
