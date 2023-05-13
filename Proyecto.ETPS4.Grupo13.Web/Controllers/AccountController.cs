using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Proyecto.ETPS4.Grupo13.Entities.DataTransferObjects;
using Proyecto.ETPS4.Grupo13.Entities.Models;
using Proyecto.ETPS4.Grupo13.Service.Contracts;

namespace Proyecto.ETPS4.Grupo13.Web.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private readonly IServiceManager _service;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly INotyfService _notyf;

        public AccountController(UserManager<User> userManager,
            SignInManager<User> signInManager, IServiceManager service, INotyfService notyf)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _service = service;
            _notyf = notyf;
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.User.Identity!.IsAuthenticated)
                return Redirect("/home");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserForAuthenticationDto dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Username);

            if (user == null)
            {
                _notyf.Error("Usuario no encontrado");
            }

            if (user != null && await _userManager.CheckPasswordAsync(user, dto.Password!))
            {
                await _signInManager.SignInAsync(user, dto.RememberMe);

                _notyf.Success("Bienvenido!");

                return Redirect("/home");
            }

            return View();
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return Redirect("/");
        }

        [HttpGet("access-denied")]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
