using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1___while
{
    class Program
    {
        static void Main(string[] args) /*Wczytaj z klawiatury dwie liczby naturalne a i b (0<a<b). Wyznacz wszystkie liczby parzyste z
przedziału [a,b]. Użyj pętli while.*/
        {
            int a, b, i;
            Console.WriteLine("Podaj dwie liczby naturalne");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            
            

            if (a < b)
            {
                if (a % 2 == 0)
                {
                    i = a;
                    while (i <= b)
                    {
                        Console.Write("{0},", i);
                        i += 2;
                    }


                    Console.ReadKey(true);
                }
                if (a % 2 == 1)
                {
                    i = a;
                    while (i <= b)
                    {
                        Console.Write("{0},", i + 1);
                        i += 2;
                    }
                    Console.ReadKey(true);
                }

            }
            else
            {
                int c = a;
                a = b;
                b=c;

                
                if (a % 2 == 0)
                {
                    i = a;

                    while (i <= b)
                    {
                        Console.Write("{0},", i);
                        i += 2;
                    }
                }
                if (a % 2 == 1)
                {
                    i = a;
                    while (i <= b)
                    {
                        Console.Write("{0},", i + 1);
                        i += 2;
                    }
                    Console.ReadKey(true);
                }

            }
        }
    }
}
