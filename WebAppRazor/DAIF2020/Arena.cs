using System;
using System.Collections.Generic;

namespace WebAppRazor.DAIF2020
{
    public partial class Arena
    {
        public int Id { get; set; }
        public string ArenaNumber { get; set; }
        public string ArenaName { get; set; }
        public string StreetAddress { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int? DistrictId { get; set; }
        public int? ArenaStatusId { get; set; }
    }
}
