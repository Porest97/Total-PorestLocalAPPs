using System;
using System.ComponentModel.DataAnnotations;

namespace PellesStats.Models
{
    public class Series
    {
        public int Id { get; set; }

        [Display(Name = "Serie")]
        public string SeriesName { get; set; }

        [Display(Name = "Startdatum")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "Slutdatum")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }
}