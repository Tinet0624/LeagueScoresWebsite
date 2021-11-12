using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeagueScoreWebsite.Data.Migrations
{
    public partial class notinitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BowlingSquads",
                columns: table => new
                {
                    BowlingSquadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BowlingSquads", x => x.BowlingSquadId);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberId);
                    table.ForeignKey(
                        name: "FK_Members_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BowlingTournamentStats",
                columns: table => new
                {
                    BowlingTournamemtStatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsNineTap = table.Column<bool>(type: "bit", nullable: false),
                    BowlingSquadId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BowlingTournamentStats", x => x.BowlingTournamemtStatId);
                    table.ForeignKey(
                        name: "FK_BowlingTournamentStats_BowlingSquads_BowlingSquadId",
                        column: x => x.BowlingSquadId,
                        principalTable: "BowlingSquads",
                        principalColumn: "BowlingSquadId");
                });

            migrationBuilder.CreateTable(
                name: "BowlingSquadMember",
                columns: table => new
                {
                    BowlingSquadsBowlingSquadId = table.Column<int>(type: "int", nullable: false),
                    MembersMemberId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BowlingSquadMember", x => new { x.BowlingSquadsBowlingSquadId, x.MembersMemberId });
                    table.ForeignKey(
                        name: "FK_BowlingSquadMember_BowlingSquads_BowlingSquadsBowlingSquadId",
                        column: x => x.BowlingSquadsBowlingSquadId,
                        principalTable: "BowlingSquads",
                        principalColumn: "BowlingSquadId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BowlingSquadMember_Members_MembersMemberId",
                        column: x => x.MembersMemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BowlingGameStats",
                columns: table => new
                {
                    BowlingGameStatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BowlingTournamentStatsBowlingTournamemtStatId = table.Column<int>(type: "int", nullable: false),
                    BowlingGameScore = table.Column<int>(type: "int", nullable: false),
                    PlayerHandicap = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BowlingGameStats", x => x.BowlingGameStatID);
                    table.ForeignKey(
                        name: "FK_BowlingGameStats_BowlingTournamentStats_BowlingTournamentStatsBowlingTournamemtStatId",
                        column: x => x.BowlingTournamentStatsBowlingTournamemtStatId,
                        principalTable: "BowlingTournamentStats",
                        principalColumn: "BowlingTournamemtStatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BowlingGameStats_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BowlingGameStats_BowlingTournamentStatsBowlingTournamemtStatId",
                table: "BowlingGameStats",
                column: "BowlingTournamentStatsBowlingTournamemtStatId");

            migrationBuilder.CreateIndex(
                name: "IX_BowlingGameStats_MemberId",
                table: "BowlingGameStats",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_BowlingSquadMember_MembersMemberId",
                table: "BowlingSquadMember",
                column: "MembersMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_BowlingTournamentStats_BowlingSquadId",
                table: "BowlingTournamentStats",
                column: "BowlingSquadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BowlingGameStats");

            migrationBuilder.DropTable(
                name: "BowlingSquadMember");

            migrationBuilder.DropTable(
                name: "BowlingTournamentStats");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "BowlingSquads");
        }
    }
}
