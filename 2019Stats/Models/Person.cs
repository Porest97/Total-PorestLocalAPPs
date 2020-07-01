using System.ComponentModel.DataAnnotations;

namespace _2019Stats.Models
{
    public class Person
    {
        public int Id { get; set; }
        //Person props
        [Display(Name = "Förnamn")]
        public string FirstName { get; set; }

        [Display(Name = "Efternamn")]
        public string LastName { get; set; }

        public string FullName { get { return string.Format("{0} {1} ", FirstName, LastName); } }

        [Display(Name = "Gatuadress")]
        public string StreetAddress { get; set; }

        [Display(Name = "Post Nr")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Display(Name = "Post Ort")]
        public string County { get; set; }

        [Display(Name = "Land")]
        public string Country { get; set; }

        [Display(Name = "Adress")]
        public string Address { get { return string.Format("{0} {1} {2}", StreetAddress, ZipCode, County); } }

        [Display(Name = "Personnummer")]
        public string Ssn { get; set; }

        [Display(Name = "Telefonnummer")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "E-Post")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}