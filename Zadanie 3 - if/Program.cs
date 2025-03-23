using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3___if
{
    class Program
    {
        static void Main(string[] args)//Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i największej z tych liczb. 
        {
            int max, min, a, b, c;
            Console.WriteLine("Podaj 3 liczby");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            max = a;
            if (max < b) max = b;
            if (max < c) max = c;
            min = a;
            if (min > b) min = b;
            if (min > c) min = c;
            Console.WriteLine("Największa liczba to {0}, a najmniejsza to {1}", max, min);
            Console.ReadKey(true);
        }
    }
}
