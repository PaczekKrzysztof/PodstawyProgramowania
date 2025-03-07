using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_if
{
    class Program
    {
        static void Main(string[] args)/*Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest
dodatnia, ujemna, czy też równa zero.*/
        {
            int a;
            Console.WriteLine("Podaj liczbe mordo");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
                Console.WriteLine("Twoja liczba jest równa 0");
            else if (a > 0)
                Console.WriteLine("Twoja liczba jest dodatnia");
            else
                Console.WriteLine("Twoja liczba jest ujemna");

        }
    }
}
