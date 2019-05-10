using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HockeyStats.Models
{
    public class Match
    {
       
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public Arena Arena { get; set; }

        public Team Team1 { get; set; }

        public Team Team2 { get; set; }

        public int? ScoreTeam1 { get; set; }

        public int? ScoreTeam2 { get; set; }

        public Referee Referee1 { get; set; }

        public Referee Referee2 { get; set; }

        public Referee Referee3 { get; set; }

        public Referee Referee4 { get; set; }

    }
}
