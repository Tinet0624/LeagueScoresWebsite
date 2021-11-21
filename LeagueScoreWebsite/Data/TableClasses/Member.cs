using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueScoreWebsite
{
    public class Member
    {   [Key]
        [ForeignKey(nameof(Id))]
        public string MemberId { get; set; } // shows as a list of members

        public string FName { get; set; }

        public string LName { get; set; }

        public DateTime DateOfBirth { get; set; } //yyyy, mm, dd              <---look here for datetime issues

        //public bool IsAdmin { get; set; } // can use role for this property...

        public IdentityUser Id { get; set; }

        public List<BowlingSquad> BowlingSquads { get; set; }
    }

    // GetAllAvailableBowlingSquads()
    // Return a list of bowling squads with less than 4 members.
}
