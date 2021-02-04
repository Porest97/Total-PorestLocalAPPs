using System;
using System.Collections.Generic;

namespace WebAppRazor.DAIF2020
{
    public partial class Club
    {
        public int Id { get; set; }
        public string ClubNumber { get; set; }
        public string ClubName { get; set; }
        public string ShortName { get; set; }
        public string StreetAddress { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int? DistrictId { get; set; }
        public int? ArenaId { get; set; }
        public int? ClubStatusId { get; set; }
    }
}
