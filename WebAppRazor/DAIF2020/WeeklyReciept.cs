using System;
using System.Collections.Generic;

namespace WebAppRazor.DAIF2020
{
    public partial class WeeklyReciept
    {
        public int Id { get; set; }
        public int? ReceiptStatusId { get; set; }
        public int? PersonId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
