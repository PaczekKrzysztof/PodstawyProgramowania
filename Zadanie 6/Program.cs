using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    class Program
    {
        static void Main(string[] args)// wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i/

        {
            double a, b;
            Console.WriteLine("Podaj a i b");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
         
            Console.WriteLine("Wynik dodawania {0}", a + b);
            Console.WriteLine("Wynik odejmowania {0}",a - b);
            Console.WriteLine("Wynik mnożenia {0}",a*b);
            
            if (b==0)
            {
                Console.WriteLine("Nie mozna dzielic przez 0");
            }
            else
            {
                Console.WriteLine("Wynik dzielenia {0}", a / b);
            }
            Console.ReadKey(true);

        }
    }
}
