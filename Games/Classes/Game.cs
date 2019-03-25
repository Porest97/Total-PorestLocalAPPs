using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Games.Models
{
    public class Game
    {
        public int Id { get; set; }
        public DateTime GameDate { get; set; }
        public DayOfWeek GameDay { get; set; }
        public Series Series { get; set; }
        public Series GameTime { get; set; }

        public Arena Arena { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public Referee Ref1 { get; set; }
        public Referee Ref2 { get; set; }
        public Series Fee1 { get; set; }
        public Series Fee2 { get; set; }
    }
}
