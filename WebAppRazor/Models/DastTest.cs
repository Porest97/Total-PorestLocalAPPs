using System;
using System.Collections.Generic;

namespace WebAppRazor.Models
{
    public partial class DastTest
    {
        public int Id { get; set; }
        public DateTime DateTimePreformed { get; set; }
        public int? ArenaId { get; set; }
        public int? SportId { get; set; }
        public int? PersonId { get; set; }
        public decimal TimeSet1 { get; set; }
        public decimal TimeSet2 { get; set; }
        public decimal TimeSet3 { get; set; }
        public decimal TimeSet4 { get; set; }
        public decimal TimeTotal { get; set; }
        public bool Approved { get; set; }

        public virtual Arena Arena { get; set; }
        public virtual Person Person { get; set; }
        public virtual Sport Sport { get; set; }
    }
}
