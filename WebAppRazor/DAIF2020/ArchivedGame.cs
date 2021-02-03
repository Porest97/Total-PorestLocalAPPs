using System;
using System.Collections.Generic;

namespace WebAppRazor.DAIF2020
{
    public partial class ArchivedGame
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string GameNumber { get; set; }
        public string GameCetegory { get; set; }
        public string GameStatus { get; set; }
        public string GameType { get; set; }
        public string Arena { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public string Score { get; set; }
        public string Hd1 { get; set; }
        public string Hd2 { get; set; }
        public string Ld1 { get; set; }
        public string Ld2 { get; set; }
        public decimal ParticipatedTime { get; set; }
        public int? PersonId { get; set; }
    }
}
