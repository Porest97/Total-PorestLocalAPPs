using System;
using System.Collections.Generic;

namespace WebAppRazor.DAIF2020
{
    public partial class Person
    {
        public int Id { get; set; }
        public int? PersonRoleId { get; set; }
        public int? PersonStatusId { get; set; }
        public int? PersonTypeId { get; set; }
        public int? ClubId { get; set; }
        public int? DistrictId { get; set; }
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
        public string SwishNumber { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
    }
}
