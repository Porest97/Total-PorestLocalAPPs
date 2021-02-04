using System;
using System.Collections.Generic;

namespace WebAppRazor.DAIF2020
{
    public partial class PoolGame
    {
        public int Id { get; set; }
        public DateTime PoolGameDateTime { get; set; }
        public string PoolGameName { get; set; }
        public int? ArenaId { get; set; }
        public int? ClubId { get; set; }
        public int? ZoneGameId { get; set; }
        public int? ZoneGameId1 { get; set; }
        public int? ZoneGameId2 { get; set; }
    }
}
