using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5___if
{
    class Program
    {
        static void Main(string[] args)//Napisać program wczytujący rok i wypisujący na ekranie informację czy jest to rok przestępny czy też nie. 
        {
            int a;
            Console.WriteLine("Podaj rok:");
            a = Convert.ToInt32(Console.ReadLine());
            if ((a % 4 == 0) && (a%100 != 0))
            {
                Console.WriteLine("Rok {0} jest przestępny", a);
            }
            else if (a % 400 == 0)

            {
                Console.WriteLine("Rok {0} jest przestępny", a);
            }
            else
            {
                Console.WriteLine("Rok {0} nie jest przestępny", a);
            }
            Console.ReadKey(true);
        }
    }
}
