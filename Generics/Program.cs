using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            Console.WriteLine(sehirler.Count);
            sehirler.Add("Nurhak");
            Console.WriteLine(sehirler[0]);
            Console.WriteLine(sehirler.Count);


            MyList<String> sehirler2 = new MyList<string>();
            Console.WriteLine(sehirler2.Count);
            sehirler2.Add("Maraş");
            
            Console.WriteLine(sehirler2.Count);

            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
        }
        class MyList<T>  //Generic Class
        {
            T[] _array;
            T[] _tempArray;
            public MyList()
            {
                _array = new T[0];

            }
            public void Add(T item)
            {
                _tempArray  = _array;
                _array = new T[_array.Length + 1];
                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _array[i] = _tempArray[i];
                }
                _array[_array.Length - 1] = item;
            }

            public int Count
            {
                get { return _array.Length; }
              
            }

        }
    }
}
