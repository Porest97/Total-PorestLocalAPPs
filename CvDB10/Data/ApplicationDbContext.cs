using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CvDB10.Models;
using CvDB10.ViewModels;

namespace CvDB10.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CvDB10.Models.Person> Person { get; set; }
        public DbSet<CvDB10.ViewModels.UsersViewModel> UsersViewModel { get; set; }
    }
}
