using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSayan.Application.Repositories.Customers;

namespace SSayan.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerWriteRepository _customerWriteRepository;

        public CustomerController(ICustomerWriteRepository customerWriteRepository)
        {
            _customerWriteRepository = customerWriteRepository;
        }

        [HttpGet]
        public async Task Add()
        {
            await _customerWriteRepository.AddRangeAsync(new()
            {
                new() {Id = Guid.NewGuid(),Name ="Ferhan",TelefonNumber = "5383972822",Surname = "Abacı"},
                new() {Id = Guid.NewGuid(),Name ="Sıla",TelefonNumber = "5383972822",Surname = "Abacı"},
                new() {Id = Guid.NewGuid(),Name ="Ahmet",TelefonNumber = "5383972822",Surname = "Abacı"},
                new() {Id = Guid.NewGuid(),Name ="Mehmet",TelefonNumber = "5383972822",Surname = "Abacı"}

            });
            await _customerWriteRepository.SaveAsync();
        }

    }
}
