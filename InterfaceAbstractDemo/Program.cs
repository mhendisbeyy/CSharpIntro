using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Concrete;

using System;
using InterfaceAbstractDemo.Adapters;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1994, 2, 16), FirstName = "Ali", LastName = "ATALAY", NationalityId = "56866310500" });

            BaseCustomerManager customerManager1 = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager1.Save(new Customer { DateOfBirth = new DateTime(1994, 2, 16), FirstName = "Hüseyin", LastName = "ATALAY", NationalityId = "1234567890" });
            Console.ReadLine();

        }
    }
}
