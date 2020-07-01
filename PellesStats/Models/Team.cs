using System.ComponentModel.DataAnnotations;

namespace PellesStats.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Display(Name = "Lag")]
        public string TeamName { get; set; }
    }
}