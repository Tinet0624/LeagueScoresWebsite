namespace LeagueScoreWebsite
{
    public class BowlingTournamentStats
    {

        public int BowlingTournamemtStatsId { get; set; }
        public bool IsNineTap { get; set; }

        public List<BowlingGameStats> BowlingGameStats { get; set; }


    }
}
