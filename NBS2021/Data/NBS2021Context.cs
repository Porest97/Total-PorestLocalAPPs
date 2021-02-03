using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NBS.Models.DataModels;
using NBS2021.Models.DataModels;

namespace NBS2021.Data
{
    public class NBS2021Context : DbContext
    {
        public NBS2021Context (DbContextOptions<NBS2021Context> options)
            : base(options)
        {
        }

        public DbSet<NBS.Models.DataModels.Person> Person { get; set; }

        public DbSet<NBS.Models.DataModels.PersonAccounts> PersonAccounts { get; set; }

        public DbSet<NBS2021.Models.DataModels.SallaryAccount> SallaryAccount { get; set; }

        public DbSet<NBS2021.Models.DataModels.Transaction> Transaction { get; set; }
    }
}
