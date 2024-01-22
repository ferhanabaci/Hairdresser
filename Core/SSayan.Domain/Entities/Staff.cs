using SSayan.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSayan.Domain.Entities
{
    public class Staff : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string SocialMedia { get; set; }
        public Customer Customer { get; set; }
    }
}
