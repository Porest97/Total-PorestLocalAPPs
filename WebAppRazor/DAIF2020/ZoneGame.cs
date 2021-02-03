using System;
using System.Collections.Generic;

namespace WebAppRazor.DAIF2020
{
    public partial class ZoneGame
    {
        public int Id { get; set; }
        public int? GameCategoryId { get; set; }
        public int? GameStatusId { get; set; }
        public int? GameTypeId { get; set; }
        public int? ZoneId { get; set; }
        public string TsmnumberZone1 { get; set; }
        public int? ClubId { get; set; }
        public int? ClubId1 { get; set; }
        public int? PersonId { get; set; }
        public int? ZoneId1 { get; set; }
        public string TsmnumberZone2 { get; set; }
        public int? ClubId2 { get; set; }
        public int? ClubId3 { get; set; }
        public int? PersonId1 { get; set; }
        public int? PersonId2 { get; set; }
        public int? ArenaId { get; set; }
        public DateTime ZoneGameDateTime { get; set; }
        public string ZoneGameName { get; set; }
    }
}
