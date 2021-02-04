using System;
using System.Collections.Generic;

namespace WebAppRazor.DAIF2020
{
    public partial class Activity
    {
        public int Id { get; set; }
        public string ActivityName { get; set; }
        public int? ActivityStatusId { get; set; }
        public DateTime FromDateTime { get; set; }
        public DateTime ToDateTime { get; set; }
        public int? GameId { get; set; }
        public int? PersonId { get; set; }
        public int? MeetingId { get; set; }
    }
}
