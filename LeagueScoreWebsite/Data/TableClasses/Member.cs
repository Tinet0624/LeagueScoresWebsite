using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueScoreWebsite
{
    public class Member
    {   [Key]
        [ForeignKey(nameof(Id))]
        public int MemberId { get; set; } //this is linked to Identity ID field somehow this was done

        public string FName { get; set; }

        public string LName { get; set; }

        public DateOnly DateOfBirth { get; set; } //yyyy, mm, dd              <---look here for datetime issues

        //public bool IsAdmin { get; set; } // can use role for this property...

        public IdentityUser Id { get; set; }

        //public List<BowlingSquad> BowlingSquads { get; set; }

        //this is linked to Rolls?



    }
}
