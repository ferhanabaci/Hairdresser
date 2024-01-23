using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSayan.Application.Features.Commands.Customer.CreateCustomer;
using SSayan.Application.Features.Queries.Customer.GetByCustomer;
using SSayan.Application.Repositories.Customers;
using SSayan.Domain.Entities;
using System.Net;

namespace SSayan.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        readonly IMediator _mediator;

        public CustomerController(ICustomerWriteRepository customerWriteRepository, IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateCustomerCommandRequest createCustomer)
        {
            CreateCustomerCommandResponse createCustomerCommandResponse = await _mediator.Send(createCustomer);
            return Ok(HttpStatusCode.Created);
                
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdCustomerQueryRequest getByIdCustomerQueryRequest)
        {
            GetByIdCustomerQueryResponse response = await _mediator.Send(getByIdCustomerQueryRequest);
            return Ok(response);
        }

    }
}
