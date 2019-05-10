using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProManager.Models
{
    public class Person : IdentityUser
    {
       // public int Id { get; set; }

        public long Ssn { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Fullname { get { return string.Format("{0} {1}", FirstName, LastName); } }

        public string StreetAddress { get; set; }
        public string ZipCode { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
    }
}
