using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)//Napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód.
        {
            int a, b;
            Console.WriteLine("Podaj boki prostokąta.");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pole tego prostokąta to {0}, a obwód to {1}", a * b, a + b + a + b);
            Console.ReadKey(true);

        }
    }
}
