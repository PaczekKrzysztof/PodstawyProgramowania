using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4___if
{
    internal class Program
    {
        static void Main(string[] args)//Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej
//największej z tych liczb
        {
            int a, b, c, d, e, min, max;
            Console.WriteLine("Podaj 5 liczb mordo");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
            Console.WriteLine("Liczba {0} jest najmniejsza", min);
            max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            Console.WriteLine("Liczba {0} jest największa", max);
            Console.ReadKey(true);

        }
    }
}
