using Microsoft.AspNetCore.Mvc;

namespace Semana07UESANSalesMVC.WEB.Areas.Marketing.Controllers
{
    [Area("Marketing")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
