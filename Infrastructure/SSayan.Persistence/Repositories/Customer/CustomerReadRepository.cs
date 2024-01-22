using SSayan.Application.Repositories.Customers;
using SSayan.Domain.Entities;
using SSayan.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSayan.Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(SSayanDbContext context) : base(context)
        {
        }
    }
}
