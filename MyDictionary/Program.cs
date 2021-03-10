using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dictionary<int, string> sayilar = new Dictionary<int, string>();
            sayilar.Add(5, "BES");
            Console.WriteLine(sayilar[5]);


            Console.WriteLine("----------------------");

            MyDictionary<int, string> dersler = new MyDictionary<int, string>();
            dersler.Add(1, "Veri Tabanı");
            dersler.Add(2, "Yazılım Mühendisliği");
            dersler.Add(3, "Veri Yapıları");
            dersler.Add(4, "Yapay Zeka");
            Console.Write("Seçilen dersler : ");
            Random rnd = new Random();
            int ders = rnd.Next(1, 5);
            Console.WriteLine(dersler.Count);
            dersler.Show();
            

        }
    }

    class MyDictionary<T,A>
    {
        T[] keys;
        A[] values;
        T[] tempKeys;
        A[] tempValues;

        public MyDictionary()
        {
            keys = new T[0];
            values = new A[0];
        }

        public void Add(T key,A value)
        {
            tempKeys = keys;
            keys = new T[keys.Length + 1];
            tempValues = values;
            values = new A[values.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            keys[keys.Length - 1] = key;

            for (int j = 0; j < tempValues.Length; j++)
            {
                values[j] = tempValues[j];
            }
            values[values.Length - 1] = value;

        }

        public int Count
        {
            get { return keys.Length ; }

        }
        public void Show ()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("ID: " + keys[i] + " Ders: " + values[i]);
            }
        }
    }
}
