using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FootballContext>();
            
            using (var context = new FootballContext(builder.Options))
            {
                context.Database.EnsureCreated();
                context.Teams.Add(new FootballTeam
                {
                    TeamName = "TeamName01",
                    City = "City01",
                    Wins = 30,
                    Losses = 5,
                    Draws = 10
                });

                context.Teams.Add(new FootballTeam
                {
                    TeamName = "TeamName02",
                    City = "City02",
                    Wins = 20,
                    Losses = 10,
                    Draws = 5
                });

                context.SaveChanges();
                var teams = context.Teams.ToList();
                foreach (var t in teams)
                {
                    Console.WriteLine($"Команда: {t.TeamName}, Город: {t.City}, Победы: {t.Wins}, Поражения: {t.Losses}, Ничьи: {t.Draws}");
                }
            }
        }
    }
}

