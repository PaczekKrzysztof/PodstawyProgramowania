using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6___WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)/*Napisać program, który będzie umożliwiał użytkownikowi obliczenia pól figur płaskich. 
          Jeżeli użytkownik wybierze 1, to powinien mieć możliwość obliczenia pola prostokąta,   dla 2 – pola kwadratu, a dla 3 – pola trójkąta. 
            Program powinien pytać użytkownika, które pole chce obliczyć aż do momentu, kiedy użytkownik wpisze 0 (zero). */
        {
            Double tablica,a, b, c, d, h;
            do
            {
                Console.WriteLine("Które pole chcesz obliczyć? Wpisz odpowiednią cyfrę:");
                Console.WriteLine("1 - Prostokąt");
                Console.WriteLine("2 - Kwadrat");
                Console.WriteLine("3 - Trójkąt");
                Console.WriteLine("0 - zakończ program");
                tablica = Convert.ToDouble(Console.ReadLine());

                switch (tablica)
                {
                    case 1:
                        Console.WriteLine("Podaj a:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Podaj b:");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole tego prostokąta wynosi {0}", a * b);
                        Console.WriteLine(""); break;
                    case 2:
                        Console.WriteLine("Podaj a");
                        c = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole tego kwadratu to {0}", c * c);
                        Console.WriteLine(""); break;
                    case 3:
                        Console.WriteLine("Podaj a");
                        d = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Podaj h");
                        h = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole tego trójkąta wynosi {0}", (d / 2) * h);
                        Console.WriteLine(""); break;
                    case 0:
                        Console.Write(""); break;

                    default:
                        Console.WriteLine("Proszę podaj liczbę z zakresu 0-3");
                        Console.WriteLine(""); break;
                }

            } while (tablica != 0);
            Console.WriteLine("Dziękuje za skorzystanie z programu");
            Console.ReadKey(true);
            
        }
    }
}
