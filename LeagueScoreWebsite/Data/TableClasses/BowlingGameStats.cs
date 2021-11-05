namespace LeagueScoreWebsite
{
    public class BowlingGameStats
    {
        
        //public AspNetUsers MemberID { get; set; } this is a place holde because nothing links to identity but members
        public int BowlingGameStatsID { get; set; }

        public BowlingTournamentStats BowlingTournamentStats { get; set;}

        public int BowlingGameScore { get; set; }

        public int PlayerHandicap { get; set; }
    }
}
