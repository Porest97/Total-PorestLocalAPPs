using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROHockeyManager2021.Data
{
    public class PROHockeyManagerContext : IdentityDbContext
    {
        public PROHockeyManagerContext(DbContextOptions<PROHockeyManagerContext> options)
            : base(options)
        {
        }
    }
}
