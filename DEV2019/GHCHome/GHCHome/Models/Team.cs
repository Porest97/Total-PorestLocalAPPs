using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GHCHome.Models
{
    public class Team
    {
        public int Id { get; set; }
        
        public DateTime DateCreated { get; set; } = DateTime.Now;

    }
}
