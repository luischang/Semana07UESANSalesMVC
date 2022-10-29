namespace Semana07UESANSalesMVC.WEB.ViewModels
{
    public class UsersViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string RoleCode { get; set; }
        public bool IsActive { get; set; }
    }

    public class UsersLoginViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string RoleCode { get; set; }

    }

    public class UsersAuthenticationViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
