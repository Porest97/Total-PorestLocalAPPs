using System;
using System.Collections.Generic;

namespace WebAppRazor.DAIF2020
{
    public partial class Location
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public string StreetAddress { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
