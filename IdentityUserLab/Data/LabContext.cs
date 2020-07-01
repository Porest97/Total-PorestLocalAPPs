using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IdentityUserLab.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IdentityUserLab.Data
{
    public class LabContext : IdentityDbContext
    {
        public LabContext (DbContextOptions<LabContext> options)
            : base(options)
        {
        }

        public DbSet<IdentityUserLab.Models.Person> Person { get; set; }
    }
}
