using System;
using System.Collections.Generic;

namespace WebAppRazor.DAIF2020
{
    public partial class Tsmgame
    {
        public int Id { get; set; }
        public DateTime GameDateTime { get; set; }
        public string WeekDay { get; set; }
        public int? GameNumber { get; set; }
        public int? Round { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public string Arena { get; set; }
        public string Series { get; set; }
        public string Hd1 { get; set; }
        public string Hd2 { get; set; }
        public string Ld1 { get; set; }
        public string Ld2 { get; set; }
        public string Supervisor { get; set; }
        public DateTime? DateChanged { get; set; }
        public string ChangedBy { get; set; }
        public int? TsmgameStatusId { get; set; }
    }
}
