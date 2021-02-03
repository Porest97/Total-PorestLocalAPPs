using System;
using System.Collections.Generic;

namespace WebAppRazor.Models
{
    public partial class Workout
    {
        public int Id { get; set; }
        public DateTime DateTimeStarted { get; set; }
        public DateTime DateTimeEnded { get; set; }
        public int? ArenaId { get; set; }
        public int? SportId { get; set; }
        public int? PersonId { get; set; }
        public decimal Duration { get; set; }
        public decimal Distance { get; set; }
        public decimal Kcal { get; set; }
        public bool Status { get; set; }

        public virtual Arena Arena { get; set; }
        public virtual Person Person { get; set; }
        public virtual Sport Sport { get; set; }
    }
}
