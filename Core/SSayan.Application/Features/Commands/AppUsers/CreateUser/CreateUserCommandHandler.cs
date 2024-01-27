using MediatR;
using Microsoft.AspNetCore.Identity;
using SSayan.Application.Exceptions;
using SSayan.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSayan.Application.Features.Commands.AppUsers.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly UserManager<AppUser> _userManager;

        public CreateUserCommandHandler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            IdentityResult result = await _userManager.CreateAsync(new()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = request.UserName,
                Email = request.Email
            },request.Password);

            CreateUserCommandResponse response = new() { Succeeded = result.Succeeded};

            if (result.Succeeded)
                response.Message = "Kullanıcı başarılı bir seilde oluşturuldu";
            else
                foreach (var eror in result.Errors)
                    response.Message += $"{eror.Code}- {eror.Description}<br>";
                
            return response;
        }
    }
}
