using Newtonsoft.Json;
using Semana07UESANSalesMVC.WEB.ViewModels;
using System.Text;

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

        public static async Task<bool> InsertCustomer(CustomerInsertViewModel customer)
        {
            var url = "http://localhost:5284/api/Customer";
            var json = JsonConvert.SerializeObject(customer);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using var htppClient = new HttpClient();
            using var response = await htppClient.PostAsync(url, data);
            var apiResponse = await response.Content.ReadAsStringAsync();
            var customerReponse = JsonConvert.DeserializeObject<bool>(apiResponse);
            return customerReponse;
        }


    }
}
