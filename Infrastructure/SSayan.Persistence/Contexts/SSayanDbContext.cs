using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SSayan.Domain.Entities;
using SSayan.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSayan.Persistence.Contexts
{
    public class SSayanDbContext : IdentityDbContext<AppUser,AppRole,string>
    {
        public SSayanDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
