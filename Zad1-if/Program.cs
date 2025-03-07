using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1_if
{
    class Program
    {
        static void Main(string[] args)/*Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to
liczba parzysta, czy też nieparzysta*/
        {
            int a;
            Console.WriteLine("Podaj liczbe mordo");
           a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
                Console.WriteLine("Twoja liczba jest parzysta");
            else
                Console.WriteLine("Twoja liczba nie jest parzysta");
            Console.ReadKey(true);
        }
        
    }
}
