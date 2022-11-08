using Microsoft.AspNetCore.Mvc;
using Semana07UESANSalesMVC.WEB.Services;
using Semana07UESANSalesMVC.WEB.ViewModels;

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

        public async Task<IActionResult> Obtener(int id) 
        {
            var customer = await CustomerService.GetCustomerById(id);
            return Json(customer);
        }

        public async Task<IActionResult> Guardar(int idCliente, string nombre, string apellido,
                                                    string ciudad, string telefono, string pais)
        {

            bool exito = true;
            if (idCliente == -1)//Es un nuevo registro
            {
                var objCustomer = new CustomerInsertViewModel()
                {
                    FirstName = nombre,
                    LastName = apellido,
                    City = ciudad,
                    Country = pais,
                    Phone = telefono
                };
                exito = await CustomerService.InsertCustomer(objCustomer);
            }
            else
            {//Aquí va el Update
                var objCustomer = new CustomerViewModel()
                {
                    Id = idCliente,
                    FirstName = nombre,
                    LastName = apellido,
                    City = ciudad,
                    Country = pais,
                    Phone = telefono
                };
                exito = await CustomerService.UpdateCustomer(objCustomer);
            }

            return Json(exito);
        }

        public async Task<IActionResult> Eliminar(int id)
        {
            var exito = await CustomerService.DeleteCustomer(id);
            return Json(exito);            
        }



    }
}
