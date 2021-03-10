using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Ders = new Dictionary<int, string>();
            Ders.Add(1, "Veri Tabanı");
            Ders.Add(2, "Yazılım Mühendisliği");
            Ders.Add(3, "Veri Yapıları");
            Ders.Add(4, "Yapay Zeka");
            Console.Write("Seçilen Ders : ");
            Random rnd = new Random();
            int ders = rnd.Next(1, 5);
            Console.WriteLine(Ders[ders]);
        }
    }
}
