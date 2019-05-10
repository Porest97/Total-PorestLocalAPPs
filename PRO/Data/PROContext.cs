using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PRO.Models;

namespace PRO.Models
{
    public class PROContext : DbContext
    {
        public PROContext (DbContextOptions<PROContext> options)
            : base(options)
        {
        }

        public DbSet<PRO.Models.Match> Match { get; set; }

        public DbSet<PRO.Models.Arena> Arena { get; set; }

        public DbSet<PRO.Models.Referee> Referee { get; set; }

        public DbSet<PRO.Models.Team> Team { get; set; }
    }
}
