using MediatR;
using SSayan.Application.Repositories.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = SSayan.Domain.Entities;

namespace SSayan.Application.Features.Queries.Customer.GetByCustomer
{
    internal class GetByIdCustomerQueryHandler : IRequestHandler<GetByIdCustomerQueryRequest,GetByIdCustomerQueryResponse>
    {
        readonly ICustomerReadRepository _customerReadRepository;

        public GetByIdCustomerQueryHandler(ICustomerReadRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

        public async Task<GetByIdCustomerQueryResponse> Handle(GetByIdCustomerQueryRequest pRequest,CancellationToken cancellationToken)
        {
            C.Customer customer = await _customerReadRepository.GetByIdAsync(pRequest.Id, false);
            return new() 
            {
                Name = customer.Name,
                Surname = customer.Surname,
                TelefonNumber = customer.TelefonNumber,
            };
        }
    }
}
