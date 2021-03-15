using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer {FirstName="Ali",LastName="ATALAY",ID=1,City="Nurhak"},
                new Student { FirstName="Hüseyin",LastName="ATALAY",ID=2,Department="Computer Science"},
                new Person{FirstName="Ahmet",LastName="ATALAY"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }
    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Person2
    {

    }

    class Customer:Person
    {
        public string City { get; set; }
    }
    class Student:Person
    {
        public string Department { get; set; }
    }
}
