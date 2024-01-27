using MediatR;
using Microsoft.AspNetCore.Identity;
using SSayan.Application.Exceptions;
using SSayan.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSayan.Application.Features.Commands.AppUsers.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
    {
        readonly UserManager<AppUser> _userManager;
        readonly SignInManager<AppUser> _signInManager;

        public LoginUserCommandHandler(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
        {
            AppUser user = await _userManager.FindByNameAsync(request.UsernameOrEmail); // kullanıcıyı bul 

            if (user == null)
                user = await _userManager.FindByNameAsync(request.UsernameOrEmail);

            if (user == null)
                throw new LoginUserFailedException();
           SignInResult result = await _signInManager.CheckPasswordSignInAsync(user,request.Password,false); // böyle bir kullanıcı var mı check et 
            if (result.Succeeded) // Authentication basarılı olmustur
                return new();
            return null;
        }
    }
}
