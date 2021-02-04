using NBS.Models.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NBS2021.Models.DataModels
{
    public class SallaryAccount
    {
        public int Id { get; set; }

        [Display(Name = "Account Owner")]
        public int PersonId { get; set; }
        [Display(Name = "Account Owner")]
        [ForeignKey("PersonId")]
        public Person AccountOwner { get; set; }

        [Display(Name = "Account")]
        public string AccountName { get; set; }

        [Display(Name = "Balance")]
        public decimal AccountBalance { get; set; }
    }
}