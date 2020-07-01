using System.ComponentModel.DataAnnotations;

namespace _2019Stats.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Display(Name = "Arena")]
        public string TeamName { get; set; }
    }
}