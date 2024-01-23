using MediatR;
using SSayan.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSayan.Application.Features.Commands.Customer.CreateCustomer
{
    public class CreateCustomerCommandResponse 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TelefonNumber { get; set; }
    }
}
