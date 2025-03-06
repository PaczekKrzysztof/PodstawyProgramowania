using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)//Napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód.
        {
            int a;
            int b;
            Console.WriteLine("Podaj długość boku a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj długość boku b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pole tego prostokąta wynosi: {0}", a * b);
            Console.WriteLine("Obwód tego prostokąta wynosi: {0}", 2 * a + 2 * b);
            Console.ReadKey(true);

        }
    }
}
