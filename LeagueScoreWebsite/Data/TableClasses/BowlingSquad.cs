using System.ComponentModel.DataAnnotations;

namespace LeagueScoreWebsite
{
    public class BowlingSquad
    {
        [Key]
        public int BowlingSquadId { get; set; }

        public List<Member> Members { get; set; }

        public List<BowlingTournamentStat> BowlingTournamentStats { get; set; }
    }
}
