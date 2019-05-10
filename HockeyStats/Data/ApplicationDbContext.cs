using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HockeyStats.Models;

namespace HockeyStats.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<HockeyStats.Models.Person> Person { get; set; }
        public DbSet<HockeyStats.Models.Arena> Arena { get; set; }
        public DbSet<HockeyStats.Models.RefCategory> RefCategory { get; set; }
        public DbSet<HockeyStats.Models.RefCategoryType> RefCategoryType { get; set; }
        public DbSet<HockeyStats.Models.RefDistrikt> RefDistrikt { get; set; }
        public DbSet<HockeyStats.Models.Referee> Referee { get; set; }
        public DbSet<HockeyStats.Models.RefType> RefType { get; set; }
        public DbSet<HockeyStats.Models.Team> Team { get; set; }
    }
}
