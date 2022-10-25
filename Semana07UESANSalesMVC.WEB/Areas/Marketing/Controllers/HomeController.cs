using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Semana07UESANSalesMVC.WEB.Areas.Marketing.Models;

namespace Semana07UESANSalesMVC.WEB.Areas.Marketing.Controllers
{
    [Area("Marketing")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductsWithViewData() 
        {
            var products = GetProducts();
            ViewData["ProductList"] = products;
            ViewData["MyName"] = "My name is Luis Chang";

            return View();
        }

        public IActionResult ProductsWithViewBag()
        {
            var products = GetProducts();
            ViewBag.ProductList = products;
            ViewBag.MyName = "My name is Luis Chang";
            return View();
        }

        public IActionResult ProductsWithViewModel()
        {
            var products = GetProducts();
            return View(products);
        }



        private IEnumerable<Product> GetProducts() 
        {
            var folder = Path.Combine(Directory.GetCurrentDirectory(), "Areas\\Marketing\\Data\\products.json");
            var json = System.IO.File.ReadAllText(folder);

            var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(json);
            return products;
        }
    }
}
