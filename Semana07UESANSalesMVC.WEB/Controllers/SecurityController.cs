using Microsoft.AspNetCore.Mvc;

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

        public IActionResult Signin(string correo, string clave) 
        {
            if (correo == "admin@uesan.com" && clave == "12345678")
            {
                return RedirectToAction("Index", "Home");
            }
            else {
                return View("Login");
            }
        }



    }
}
