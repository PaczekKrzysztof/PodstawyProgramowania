using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2___if
{
    class Program
    {
        static void Main(string[] args)//Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest dodatnia, ujemna, czy też równa zero.
        {
            int a;
            Console.WriteLine("Podaj liczbę");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("Ta liczba jest dodatnia");
            if (a < 0)
                Console.WriteLine("Ta liczba jest ujemna");
            if (a == 0)
                Console.WriteLine("Ta liczba jest równa 0");
            Console.ReadKey(true);
        }
    }
}
