using System.ComponentModel.DataAnnotations;

namespace LeagueScoreWebsite
{
    public class BowlingTournamentStat
    {
        [Key]
        public int BowlingTournamemtStatId { get; set; }

        public bool IsNineTap { get; set; }

        public List<BowlingGameStat> BowlingGameStats { get; set; }
    }
}
