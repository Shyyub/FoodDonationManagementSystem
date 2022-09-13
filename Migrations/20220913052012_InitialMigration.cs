using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDonationManagementSystem.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "schoolModels",
                columns: table => new
                {
                    DonarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonarName = table.Column<string>(nullable: true),
                    DonarCity = table.Column<string>(nullable: true),
                    DonarAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schoolModels", x => x.DonarId);
                });

            migrationBuilder.InsertData(
                table: "schoolModels",
                columns: new[] { "DonarId", "DonarAddress", "DonarCity", "DonarName" },
                values: new object[] { 1, "Davangere", "Delhi", "Shyyub" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "schoolModels");
        }
    }
}
