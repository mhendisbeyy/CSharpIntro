using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();         
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

            IGetSalary[] getSalaries = new IGetSalary[2]
            {
                new Manager(),
                new Worker()
            };

            foreach (var getSalary in getSalaries)
            {
                getSalary.GetSalary();
            }
            


           
           
        }

        // SOLID , Interface Segregation
        interface IWorker
        {
            void Work();    
        }
        interface IEat
        {
            void Eat();
        }

        interface IGetSalary
        {
            void GetSalary();
        }

        class Manager : IWorker, IEat, IGetSalary
        {
            public void Eat()
            {
                Console.WriteLine("mealtime");
            }

            public void GetSalary()
            {
                Console.WriteLine("Payment time");
            }

            public void Work()
            {
                Console.WriteLine("Working time");
            }
        }
        class Worker : IWorker,IEat,IGetSalary
        {
            public void Eat()
            {
                Console.WriteLine("mealtime");
            }

            public void GetSalary()
            {
                Console.WriteLine("Payment time");
            }

            public void Work()
            {
                Console.WriteLine("Working time");
            }
        }
        class Robot : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Working time");
            }
        }
    }
}
