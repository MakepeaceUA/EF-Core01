using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp54
{
    public class FootballContext : DbContext
    {
        public DbSet<FootballTeam> Teams => Set<FootballTeam>();
        public FootballContext() => Database.EnsureCreated();

        public FootballContext(DbContextOptions<FootballContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=ARSEN;Database=Championship;Integrated Security=True;TrustServerCertificate=True;");
            }
        }
    }
}
