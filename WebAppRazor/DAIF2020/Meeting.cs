using System;
using System.Collections.Generic;

namespace WebAppRazor.DAIF2020
{
    public partial class Meeting
    {
        public int Id { get; set; }
        public string MeetingName { get; set; }
        public string MeetingDescription { get; set; }
        public int? LocationId { get; set; }
        public int? PersonId { get; set; }
    }
}
