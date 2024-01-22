using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SSayan.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace SSayan.Persistence
{
    public static class ServiceRegistraction
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<SSayanDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
        }
    }
}
