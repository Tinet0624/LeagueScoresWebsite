using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeagueScoreWebsite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        
        }

        public DbSet<Member> Members { get; set; }

        public DbSet<BowlingTournamentStat> BowlingTournamentStats { get; set; }

        public DbSet<BowlingSquad> BowlingSquads { get; set; }

        public DbSet<BowlingGameStat> BowlingGameStats { get; set; }

    }
}