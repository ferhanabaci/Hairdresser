using SSayan.Application.Repositories;
using SSayan.Domain.Entities;
using SSayan.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSayan.Persistence.Repositories
{
    public class StaffReadRepository : ReadRepository<Staff>, IStaffReadRepository
    {
        public StaffReadRepository(SSayanDbContext context) : base(context)
        {
        }
    }
}
