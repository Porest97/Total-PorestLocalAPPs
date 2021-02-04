using System;
using System.Collections.Generic;

namespace WebAppRazor.DAIF2020
{
    public partial class Game
    {
        public int Id { get; set; }
        public DateTime GameDateTime { get; set; }
        public string GameNumber { get; set; }
        public string Tsmnumber { get; set; }
        public int? GameCategoryId { get; set; }
        public int? GameStatusId { get; set; }
        public int? GameTypeId { get; set; }
        public int? ArenaId { get; set; }
        public int? ClubId { get; set; }
        public int? ClubId1 { get; set; }
        public int? HomeTeamScore { get; set; }
        public int? AwayTeamScore { get; set; }
        public int? PersonId { get; set; }
        public int? PersonId1 { get; set; }
        public int? PersonId2 { get; set; }
        public int? PersonId3 { get; set; }
        public int? SeriesId { get; set; }
    }
}
