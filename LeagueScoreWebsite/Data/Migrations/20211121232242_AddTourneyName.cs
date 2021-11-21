using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeagueScoreWebsite.Data.Migrations
{
    public partial class AddTourneyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BowlingTournamentName",
                table: "BowlingTournamentStats",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BowlingTournamentName",
                table: "BowlingTournamentStats");
        }
    }
}
