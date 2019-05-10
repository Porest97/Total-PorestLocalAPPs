using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProManager.ViewModels
{
    public class UserInputViewModel
    {
        [Display(Name ="Förnamn")]
        public string FirstName { get; set; }

        [Display(Name = "Efteramn")]
        public string LastName { get; set; }

        public string Fullname { get { return string.Format("{0} {1}", FirstName, LastName); } }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [RegularExpression(@"(?=.*\d)(?=.*[\W_]).{6,}", ErrorMessage = "Characters are not allowed.")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string StreetAddress { get; set; }
        public string ZipCode { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
    }
}
