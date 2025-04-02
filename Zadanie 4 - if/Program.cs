using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4___if
{
    class Program
    {
        static void Main(string[] args)//Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej największej z tych liczb. 
        {
            int max, min, a, b, c,d,e;
            Console.WriteLine("Podaj 5 liczb");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            max = a;
            if (max < b) max = b;
            if (max < c) max = c;
            if (max < d) max = d;
            if (max < e) max = e;
            min = a;
            if (min > b) min = b;
            if (min > c) min = c;
            if (min > d) min = d;
            if (min > e) min = e;
            Console.WriteLine("Największa liczba to {0}, a najmniejsza to {1}", max, min);
            Console.ReadKey(true);
        }
    }
}
