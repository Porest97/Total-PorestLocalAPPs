using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NBSUltra.Models.DataModels
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name = "Anst.NR")]    
        [Required]
        public string EmpNumber { get; set; }

      
        [Display(Name = "Avändare")]
        public string ApplicationUserId { get; set; }
        [Display(Name = "Användare")]
        [ForeignKey("ApplicationUserId")]       
        public ApplicationUser User { get; set; }

    }
}
