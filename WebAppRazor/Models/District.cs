using System;
using System.Collections.Generic;

namespace WebAppRazor.Models
{
    public partial class District
    {
        public int Id { get; set; }
        public string DistrictName { get; set; }
        public string StreetAddress { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
