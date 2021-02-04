using System;
using System.Collections.Generic;

namespace WebAppRazor.Models
{
    public partial class Sport
    {
        public Sport()
        {
            DastTest = new HashSet<DastTest>();
            Workout = new HashSet<Workout>();
        }

        public int Id { get; set; }
        public string SportName { get; set; }

        public virtual ICollection<DastTest> DastTest { get; set; }
        public virtual ICollection<Workout> Workout { get; set; }
    }
}
