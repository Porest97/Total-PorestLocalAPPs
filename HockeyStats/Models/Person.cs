using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HockeyStats.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
                
        public string LastName { get; set; }
        
        
        public int? RefereeId { get; set; }

        public string BirthDate { get; set; }
             
        public int? ClubId { get; set; }

        public string StreetAddress { get; set; }

        public string Zipcode { get; set; }

        public string County { get; set; }
    }
}
