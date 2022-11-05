using Newtonsoft.Json;
using Semana07UESANSalesMVC.WEB.ViewModels;

namespace Semana07UESANSalesMVC.WEB.Services
{
    public class CustomerService
    {


        public static async Task<IEnumerable<CustomerViewModel>> GetCustomers()
        {
            var url = "http://localhost:5284/api/Customer";
            using var htppClient = new HttpClient();
            using var response = await htppClient.GetAsync(url);
            var apiResponse = await response.Content.ReadAsStringAsync();
            var customers = JsonConvert.DeserializeObject<IEnumerable<CustomerViewModel>>(apiResponse);
            return customers;
        }


    }
}
