using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_11
{
    class Program
    {
        static void Main(string[] args)//Napisać program wczytujący długości boków prostopadłościanu i wypisujący na ekranie jego objętość i pole całkowite. 
        {
            double a, b, c, V, Pc;
            Console.WriteLine("Podaj 3 długości boków prostopadłościanu");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            V = a * b * c;
            Pc = 2 * (a * b) + 2 * (a * c) + 2 * (b * c);
            Console.WriteLine("Objętość wynosi {0}, a pole całkowite {1}", V, Pc);
            Console.ReadKey(true);
        }
    }
}
