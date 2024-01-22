using SSayan.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSayan.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TelefonNumber { get; set; }
        public ICollection<Staff> Staffs { get; set; }

    }
}
