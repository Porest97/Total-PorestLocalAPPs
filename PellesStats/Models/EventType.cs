using System.ComponentModel.DataAnnotations;

namespace PellesStats.Models
{
    public class EventType
    {
        public int Id { get; set; }

        [Display(Name = "Event Typ")]
        public string EventTypeName { get; set; }
    }
}