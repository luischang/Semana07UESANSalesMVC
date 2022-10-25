using Microsoft.AspNetCore.Mvc;

namespace Semana07UESANSalesMVC.WEB.Areas.Finanzas.Controllers
{
    [Area("Finanzas")]
    public class HomeController : Controller
    {      
        public IActionResult Index()
        {
            return View();
        }
    }
}
