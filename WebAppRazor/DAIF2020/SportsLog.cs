using System;
using System.Collections.Generic;

namespace WebAppRazor.DAIF2020
{
    public partial class SportsLog
    {
        public int Id { get; set; }
        public int? PersonId { get; set; }
        public int? SportId { get; set; }
        public DateTime? DateTimeStart { get; set; }
        public DateTime? DateTimeEnd { get; set; }
        public decimal TimeSpent { get; set; }
    }
}
