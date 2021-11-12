namespace LeagueScoreWebsite
{
    public class BowlingTournamentStat
    {
        public int BowlingTournamemtStatsId { get; set; }

        public bool IsNineTap { get; set; }

        public List<BowlingGameStat> BowlingGameStats { get; set; }
    }
}
