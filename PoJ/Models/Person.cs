using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoJ.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Display(Name ="Person NR 10 siffror")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:####-##-##-####}")]
        public long Ssn { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }
            
        // Player personalia !
        public Team Team { get; set; }
        public string Sex { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
        public string LorR { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public bool Captain { get; set; } = false;

        public bool AssistingCaptain { get; set; } = false;

        public bool HaeadCoach { get; set; } = false;

        public bool AssistingCoach { get; set; } = false;

        public bool Staff { get; set; } = false;

        public string TeamId { get; set; }

    }
}
