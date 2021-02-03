using System;
using System.Collections.Generic;

namespace WebAppRazor.DAIF2020
{
    public partial class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public int? ClubId { get; set; }
        public int? DistrictId { get; set; }
        public int? ArenaId { get; set; }
        public int? SeriesId { get; set; }
        public int? TeamStatusId { get; set; }
        public int? TeamRosterId { get; set; }
    }
}
