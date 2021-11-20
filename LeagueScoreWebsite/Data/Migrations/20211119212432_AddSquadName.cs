using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeagueScoreWebsite.Data.Migrations
{
    public partial class AddSquadName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BowlingSquadName",
                table: "BowlingSquads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BowlingSquadName",
                table: "BowlingSquads");
        }
    }
}
