using System.ComponentModel.DataAnnotations;

namespace PellesStats.Models
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
    }
}