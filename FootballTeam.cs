using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    public class FootballTeam
    {
        public int Id { get; set; }
        public string TeamName { get; set; } = null!;
        public string City { get; set; } = null!;
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
    }
}
