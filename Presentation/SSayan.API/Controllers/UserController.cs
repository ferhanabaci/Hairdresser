using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSayan.Application.Features.Commands.AppUsers.CreateUser;
using SSayan.Application.Features.Commands.AppUsers.LoginUser;

namespace SSayan.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateUser(CreateUserCommandRequest pRequest)
        {
            CreateUserCommandResponse response = await _mediator.Send(pRequest);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginUserCommandRequest pRequest)
        {
            LoginUserCommandResponse response = await _mediator.Send(pRequest);
            return Ok(response);
        }
    }
}
