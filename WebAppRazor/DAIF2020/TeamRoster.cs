using System;
using System.Collections.Generic;

namespace WebAppRazor.DAIF2020
{
    public partial class TeamRoster
    {
        public int Id { get; set; }
        public string TeamRosterName { get; set; }
        public int? PersonId { get; set; }
        public int? PersonId1 { get; set; }
        public int? PersonId2 { get; set; }
    }
}
