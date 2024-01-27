using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SSayan.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SSayan.Application.Repositories.Customers;
using SSayan.Persistence.Repositories;
using SSayan.Application.Repositories;
using System.Reflection;
using SSayan.Domain.Entities.Identity;

namespace SSayan.Persistence
{
    public static class ServiceRegistraction
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<SSayanDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<SSayanDbContext>();
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IStaffWriteRepository, StaffWriteRepository>();
            services.AddScoped<IStaffReadRepository, StaffReadRepository>();
        }
    }
}
