using System.ComponentModel.DataAnnotations;

namespace _2019Stats.Models
{
    public class Series
    {
        public int Id { get; set; }

        [Display(Name = "Arena")]
        public string SeriesName { get; set; }
    }
}