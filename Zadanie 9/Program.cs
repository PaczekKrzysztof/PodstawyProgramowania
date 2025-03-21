using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9
{
    class Program
    {
        static void Main(string[] args)//Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie sumę kwadratów wczytanych liczb.
        {
            int a, b, kwadrat;
            Console.WriteLine("Podaj dwie liczby");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            kwadrat = (a * a) + (b * b);
            Console.WriteLine("Suma kwadratów tych liczb wynosi {0}", kwadrat);
            Console.ReadKey(true);
        }
    }
}
