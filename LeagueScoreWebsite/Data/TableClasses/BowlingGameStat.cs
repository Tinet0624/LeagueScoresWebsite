using System.ComponentModel.DataAnnotations;

namespace LeagueScoreWebsite
{
    public class BowlingGameStat
    {
        [Key]
        public int BowlingGameStatID { get; set; }

        public Member MemberID { get; set; }


        public BowlingTournamentStat BowlingTournamentStats { get; set;}

        public int BowlingGameScore { get; set; }

        public int PlayerHandicap { get; set; }
    }
}
