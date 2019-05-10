using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RefMaster.Models
{
    public class Person : IdentityUser
    {
        
        public string FirstName { get; set; }

        
        public string LastName { get; set; }
                        
        public int? RefNumber { get; set; }

        public string BirthDate { get; set; }

        public RefType RefType { get; set; }
        public int? RefTypeId { get; set; }

        public RefCategory RefCategory { get; set; }
        public int? RefCategoryId { get; set; }

        public RefCategoryType RefCategoryType { get; set; }
        public int? RefCategoryTypeId { get; set; }

        public RefDistrikt RefDistrikt { get; set; }
        public int? RefDistriktId { get; set; }

        public Club Club { get; set; }
        public int? ClubId { get; set; }

        public string StreetAddress { get; set; }

        public string Zipcode { get; set; }

        public string County { get; set; }

        public string Country { get; set; }

        public Referee RefereeNumber { get; set; }
        public int? RefereeId { get; set; }
    }
}
