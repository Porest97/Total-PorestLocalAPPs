using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRO.Models
{
    public class Match
    {
        public int Id { get; set; }

        public Arena Arena { get; set; }
        
        public Team Team { get; set; }      

        public int? Team2 { get; set; }

       // public int? ScoreTeam1 { get; set; }

       // public int? ScoreTeam2 { get; set; }

        public Referee Referee { get; set; }        

       // public Referee Referee2 { get; set; }
        
       // public Referee Referee3 { get; set; }
       
        // public Referee Referee4 { get; set; }

        //Navigation Props !
        public int? ArenaId { get; set; }
        public int? TeamId { get; set; }
       // public int? TeamId2 { get; set; }
        public int? RefereeId { get; set; }
       // public int? RefereeId2 { get; set; }
       // public int? RefereeId3 { get; set; }
       // public int? RefereeId4 { get; set; }

    }
}
