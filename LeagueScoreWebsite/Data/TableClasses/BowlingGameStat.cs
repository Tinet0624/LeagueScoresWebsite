namespace LeagueScoreWebsite
{
    public class BowlingGameStat
    {
        public Member MemberID { get; set; }

        public int BowlingGameStatsID { get; set; }

        public BowlingTournamentStat BowlingTournamentStats { get; set;}

        public int BowlingGameScore { get; set; }

        public int PlayerHandicap { get; set; }
    }
}
