using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SecondWeek.Models;

namespace SecondWeek.Data
{
    public class SecondWeekContext : DbContext
    {
        public SecondWeekContext (DbContextOptions<SecondWeekContext> options)
            : base(options)
        {
        }

        public DbSet<SecondWeek.Models.Movies> Movies { get; set; }
    }
}
