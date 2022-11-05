using Microsoft.AspNetCore.Mvc;
using Semana07UESANSalesMVC.WEB.Services;

namespace Semana07UESANSalesMVC.WEB.Areas.Marketing.Controllers
{
    [Area("Marketing")]
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Listado()
        {
            var customers = await CustomerService.GetCustomers();
            ViewBag.CustomerList = customers;
            return PartialView();
        }
    }
}
