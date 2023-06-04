using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using app_adocao.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Identity.Client;
using Microsoft.Data.SqlClient;

namespace app_adocao.Controllers
{
    //[Authorize]
    public class UsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([Bind("Login,Senha")] Usuario usuario)
        {
            var user = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Login == usuario.Login);

            if (user == null)
            {
                ViewBag.Message = "Usuário e/ou senha Inválida!";
                return View();
            }

            bool senhaOk = BCrypt.Net.BCrypt.Verify(usuario.Senha, user.Senha);

            if (senhaOk)
            {
                var Claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Nome),
                    new Claim(ClaimTypes.NameIdentifier, user.Nome )
                };

                var userIdentifier = new ClaimsIdentity(Claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentifier);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(3),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, props);
                return Redirect($"/Responsaveis/Details/{usuario.Login}");
            }

            ViewBag.Message = "Usuário e/ou senha Inválida!";
            return View();
        }

        [AllowAnonymous]
        public IActionResult AccesDenied()
        {
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            //return RedirectToAction("Login", "Usuarios");
            return Redirect("/");
        }
    }
}
