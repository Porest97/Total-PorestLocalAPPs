using System;
using System.Collections.Generic;

namespace WebAppRazor.DAIF2020
{
    public partial class Series
    {
        public int Id { get; set; }
        public string SeriesName { get; set; }
        public int? DistrictId { get; set; }
        public int? SeriesStatusId { get; set; }
        public int? PersonId { get; set; }
    }
}
