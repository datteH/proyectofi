using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Proyecto.ETPS4.Grupo13.Entities.DataTransferObjects;
using Proyecto.ETPS4.Grupo13.Entities.Models;
using Proyecto.ETPS4.Grupo13.Repository.Contracts;
using Proyecto.ETPS4.Grupo13.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.ETPS4.Grupo13.Service
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IHttpContextAccessor _context;
        private User? _user;

        public AuthenticationService(UserManager<User> userManager, SignInManager<User> signInManager, IHttpContextAccessor context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
        public async Task<User> GetUserAsync(string username) => await _userManager.FindByEmailAsync(username);

        public async Task SignInAsync(string password, bool rememberMe) => await _signInManager.PasswordSignInAsync(_user!.Email, password, rememberMe, false);

        public async Task SignOutAsync() => await _signInManager.SignOutAsync();

        public async Task<bool> ValidateUser(UserForAuthenticationDto userForAuth)
        {
            _user = await GetUserAsync(userForAuth.Username!);

            var result = (_user != null && await _userManager.CheckPasswordAsync(_user, userForAuth.Password!));

            return result;
        }

        public async Task<User> GetConnectedUser() => await _userManager.GetUserAsync(_context.HttpContext?.User);
    }
}
