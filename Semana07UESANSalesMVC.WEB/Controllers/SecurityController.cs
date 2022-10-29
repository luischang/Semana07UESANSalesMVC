using Microsoft.AspNetCore.Mvc;
using Semana07UESANSalesMVC.WEB.Services;
using Semana07UESANSalesMVC.WEB.ViewModels;

namespace Semana07UESANSalesMVC.WEB.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> Signin(string correo, string clave) 
        {
            var userLogin = new UsersAuthenticationViewModel() 
            {
                Email = correo,
                Password = clave
            };
            var auth = await UsersService.Login(userLogin);

            if (auth == null)
                return RedirectToAction("Login");

            var roleCode = auth.RoleCode;

            if (roleCode == "FINANCE")
                return RedirectToAction("Index", "Home", new { Area = "Finanzas" });
            else if(roleCode == "MARKETING")
                return RedirectToAction("Index", "Home", new { Area = "Marketing" });
            else
                return RedirectToAction("Login");
            //if (correo == "admin@uesan.com" && clave == "12345678")
            //{
            //    return RedirectToAction("Index", "Home");
            //}
            //else {
            //    return View("Login");
            //}
        }



    }
}
