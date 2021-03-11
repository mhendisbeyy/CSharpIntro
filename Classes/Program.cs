namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            Customer customer = new Customer();
            customer.City = "Nurhak";
            customer.Id = 1;
            customer.FirstName = "Ali";
            customer.LastName = "ATALAY";


            Customer customer2 = new Customer
            {
                Id = 2, City = "Samsun", FirstName = "Burcu", LastName = "Akel"

            };

            System.Console.WriteLine(customer2.FirstName);
            System.Console.WriteLine(customer.FirstName);
        
         }
    }
}
