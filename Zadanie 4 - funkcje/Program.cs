using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4___funkcje
{
    internal class Program/*Napisz funkcję o nazwie ile_cyfr, która wyznacza liczbę cyfr dla zadanej liczby naturalnej jako
argument tej funkcji. Napisz program wykorzystujący funkcję ile_cyfr.*/
    {
        static int ile_cyfr(int liczba)
     
        {
            int i = 0;
            while (liczba / 10 > 0)
            {
                liczba /= 10;
                i++;
            }
            return i + 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba 0 ma {0} cyfrę", ile_cyfr(0));
            Console.WriteLine("Liczba 2137 ma {0} cyfr", ile_cyfr(2137));
            Console.ReadKey(true);
        }
    }
}
