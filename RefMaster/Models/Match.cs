using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefMaster.Models
{
    public class Match
    {
        public int Id { get; set; }

        public DateTime MatchDateTime { get; set; }

        public Arena Arena { get; set; }
        public int? ArenaId { get; set; }

        public Club Team1 { get; set; }
        public Club Team2 { get; set; }
        //public int ClubId { get; set; }

        public int? Team1Score { get; set; }
        public int? Team2Score { get; set; }

        public Referee Ref1 { get; set; }
        public Referee Ref2 { get; set; }
        public Referee Ref3 { get; set; }
        public Referee Ref4 { get; set; }
        public Referee Ref5 { get; set; }
        public string RefereeId { get; set; }

        public Series Series { get; set; }
        public int? SeriesId { get; set; }

        public List<Referee> Referees { get; set; }


    }
}
