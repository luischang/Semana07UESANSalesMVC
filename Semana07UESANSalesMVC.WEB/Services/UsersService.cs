using Newtonsoft.Json;
using Semana07UESANSalesMVC.WEB.ViewModels;
using System.Text;

namespace Semana07UESANSalesMVC.WEB.Services
{
    public class UsersService
    {



        public static async Task<UsersLoginViewModel> Login(UsersAuthenticationViewModel userAuth)
        {
            var json = JsonConvert.SerializeObject(userAuth);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
                            
            var url = "http://localhost:5284/api/Users/Login";
            using var httpClient = new HttpClient();
            using var response = await httpClient.PostAsync(url, data);

            var apiResponse = await response.Content.ReadAsStringAsync();
            var userResponse = JsonConvert.DeserializeObject<UsersLoginViewModel>(apiResponse);

            return userResponse;
        }



    }
}
