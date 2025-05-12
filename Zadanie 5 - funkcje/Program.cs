using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5___funkcje
{
    internal class Program/*Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcja
powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb. Przetestuj działanie
utworzonej funkcji.*/
    {
        static int czy_pierwsza(int liczba)
        {
            int i;
            for (i = 2; i < liczba / 2; i++)
                if (liczba % i == 0) return 0;
            return 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Czy 69 jest liczbą pierwszą?; {0}", czy_pierwsza(69));
            Console.WriteLine("Czy 5 jest liczba pierwzą?: {0}", czy_pierwsza(5));
            Console.ReadKey(true);

        }
    }
}
