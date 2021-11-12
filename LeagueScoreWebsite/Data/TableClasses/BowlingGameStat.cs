namespace LeagueScoreWebsite
{
    public class BowlingGameStat
    {
        
        //public AspNetUsers MemberID { get; set; } this is a place holder because nothing links to identity but members
        public int BowlingGameStatsID { get; set; }

        public BowlingTournamentStat BowlingTournamentStats { get; set;}

        public int BowlingGameScore { get; set; }

        public int PlayerHandicap { get; set; }
    }
}
