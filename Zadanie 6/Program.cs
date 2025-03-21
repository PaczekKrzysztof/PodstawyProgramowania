using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    class Program
    {
        static void Main(string[] args)//Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i iloraz.
        {
            double a, b;
            Console.WriteLine("Podaj dwie liczby");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            if (b == 0)
                Console.WriteLine("Nie można dzielić przez 0");
            else
                Console.WriteLine("Suma tych liczb wynosi {0}, różnica {1}, iloczyn {3}, a iloraz {2}", a + b, a - b, a / b,a*b);
            Console.ReadKey(true);

        }
    }
}
