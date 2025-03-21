using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8
{
    class Program
    {
        static void Main(string[] args)//Dany jest ciąg arytmetyczny a(n)=3n-1.  Napisać program wczytujący numer wyrazu ciągu (n) i wypisujący na ekranie jego wartość. 
        {
            int n;
            Console.WriteLine("Podaj numer ciągu");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wartość tego numeru ciągu to: {0}", (3 * n) - 1);
            Console.ReadKey(true);


        }
    }
}
