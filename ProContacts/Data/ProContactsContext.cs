using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProContacts.Models
{
    public class ProContactsContext : DbContext
    {
        public ProContactsContext (DbContextOptions<ProContactsContext> options)
            : base(options)
        {
        }

        public DbSet<ProContacts.Models.Contact> Contact { get; set; }
        public DbSet<ProContacts.Models.AgeCategory> AgeCategory { get; set; }
        public DbSet<ProContacts.Models.Club> Club { get; set; }
        public DbSet<ProContacts.Models.District> District { get; set; }
        public DbSet<ProContacts.Models.Role> Role { get; set; }
        public DbSet<ProContacts.Models.Season> Season { get; set; }
        public DbSet<ProContacts.Models.Sport> Sport { get; set; }
        public DbSet<ProContacts.Models.Team> Team { get; set; }

    }
}
