namespace LeagueScoreWebsite
{
    public class Member
    {
        public int MemberId { get; set; } //this is linked to Identity ID field somehow

        public string FName { get; set; }

        public string LName { get; set; }

        public DateOnly DateOfBirth { get; set; } //yy, mm, dd              <---look here for datetime issues

        public bool IsAdmin { get; set; }

        //public List<BowlingSquad> BowlingSquads { get; set; }

        //this is linked to Rolls?

        

    }
}
