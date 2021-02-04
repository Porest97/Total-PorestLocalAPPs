using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DecimalTest.Models;

namespace DecimalTest.Data
{
    public class DecimalTestContext : DbContext
    {
        public DecimalTestContext (DbContextOptions<DecimalTestContext> options)
            : base(options)
        {
        }

        public DbSet<DecimalTest.Models.DecimalHandling> DecimalHandling { get; set; }
    }
}
