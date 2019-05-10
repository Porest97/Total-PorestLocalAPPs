using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HockeyStats.Models
{
    public class Club
    {
        public int Id { get; set; }

        public string ClubName { get; set; }

        public string ClubContactPerson { get; set; }

        public string ClubEmail { get; set; }

        public string StreetAddress { get; set; }

        public string ZipCode { get; set; }

        public string County { get; set; }

        public string Country { get; set; }

        public string IdentityUserId { get; set; }
    }
}
