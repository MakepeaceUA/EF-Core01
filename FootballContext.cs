using Microsoft.EntityFrameworkCore;

namespace ConsoleApp51
{
    public class FootballContext : DbContext
    {
        public DbSet<FootballTeam> Teams { get; set; }

        public FootballContext(DbContextOptions<FootballContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=ARAKVIEL;Database=FootballChampionship;Integrated Security=True;TrustServerCertificate=True;");
            }
        }
    }
}
