using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HockeyContacs.Models
{
    public class HockeyContacsContext : DbContext
    {
        public HockeyContacsContext (DbContextOptions<HockeyContacsContext> options)
            : base(options)
        {
        }

        public DbSet<HockeyContacs.Models.Contact> Contact { get; set; }
    }
}
