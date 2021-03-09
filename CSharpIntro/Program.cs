using System;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { ID = 1, FistName = "Ali", LastName = "Atalay", City = "Kahramanmaraş" };
            Customer customer2 = new Customer(2, "Ali", "ATALAY", "Tunceli");

            Customer customer3 = new Customer();
            customer3.ID = 3;
            customer3.FistName = "Sultan";
            customer3.LastName = "DAVSAN";
            customer3.City = "Sivas";

            
            Console.WriteLine(customer1.LastName);
            Console.WriteLine(customer2.LastName);
            Console.WriteLine(customer3.LastName);
        }
    }
    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id,string firsName,String lastName,String city)
        {
            ID = id;
            FistName = firsName;
            LastName = lastName;
            City = city;
            Console.WriteLine(firsName);
         
        }
        public int ID { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
