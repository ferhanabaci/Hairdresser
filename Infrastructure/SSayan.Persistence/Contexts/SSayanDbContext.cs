using Microsoft.EntityFrameworkCore;
using SSayan.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSayan.Persistence.Contexts
{
    public class SSayanDbContext : DbContext
    {
        public SSayanDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
