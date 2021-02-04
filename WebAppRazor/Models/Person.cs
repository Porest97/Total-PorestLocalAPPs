using System;
using System.Collections.Generic;

namespace WebAppRazor.Models
{
    public partial class Person
    {
        public Person()
        {
            DastTest = new HashSet<DastTest>();
            Workout = new HashSet<Workout>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Ssn { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Email { get; set; }

        public virtual ICollection<DastTest> DastTest { get; set; }
        public virtual ICollection<Workout> Workout { get; set; }
    }
}
