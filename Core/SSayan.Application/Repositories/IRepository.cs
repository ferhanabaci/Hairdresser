using Microsoft.EntityFrameworkCore;
using SSayan.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SSayan.Application.Repositories
{
    public interface IRepository<T> where T  : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
