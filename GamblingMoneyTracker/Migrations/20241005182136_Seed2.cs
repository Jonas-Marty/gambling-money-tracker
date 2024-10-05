using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamblingMoneyTracker.Migrations
{
    /// <inheritdoc />
    public partial class Seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Players");
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Migros", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Nestle", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Kambli", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Post", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Landi", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["SBB", 0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
