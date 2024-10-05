using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamblingMoneyTracker.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Aureo", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Bischu", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Bubba", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Calimero", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Cluedo", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Coco", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Dachs", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Faja", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Fiori", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Fläsch", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Hubba", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Juna", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Konda", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Lincon", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Luba", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Lupesch", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Mammut🦣", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Mampf", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Nahari", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Nandu", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Pouw", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Scilla", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Spick", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Spirito", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Stitch", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Strobo", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Taya", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Trix", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Tschenga", 0]);
            migrationBuilder.InsertData("Players", ["Name", "PlayMoney"], ["Varuna", 0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
