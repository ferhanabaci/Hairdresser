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
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(SSayanDbContext context) : base(context)
        {
        }
    }
}
