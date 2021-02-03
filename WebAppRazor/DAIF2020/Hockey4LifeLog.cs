using System;
using System.Collections.Generic;

namespace WebAppRazor.DAIF2020
{
    public partial class Hockey4LifeLog
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Events { get; set; }
        public int HockeyDay { get; set; }
        public int DayInLife { get; set; }
        public decimal Hours { get; set; }
        public int NumberOfGames { get; set; }
        public int? GameId { get; set; }
        public int? GameId1 { get; set; }
        public int? GameId2 { get; set; }
    }
}
