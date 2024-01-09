using WebShop.Models;


namespace WebShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AddData.AddCustomerInfo();
            //AddData.AddProductInfo();
            //AddData.AddOrderInfo();
            //AddData.AddFirstProducts();
            //AddData.AddMultipleProducts();
            //AddData.AddFirstCustomers();
            var customer = new Customer();

            using (var dbContext = new MyDbContext())
            {
                var loginManager = new LoginManager(dbContext);
                customer = loginManager.Login(dbContext);
            }
            TheMenu.ShowMenu(customer);
            // AddData.AddNewCustomerWithInput();
        }
    }
}