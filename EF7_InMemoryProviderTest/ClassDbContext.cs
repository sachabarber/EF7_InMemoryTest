using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF7_InMemoryProviderTest
{
    public class ClassDbContext : DbContext
    {
        public ClassDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Person> Members { get; set; }

        public DbSet<Qualification> Qualifications { get; set; }
    }
}
