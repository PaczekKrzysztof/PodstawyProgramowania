using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7___if
{
    class Program
    {
        static void Main(string[] args)/*Napisać program wczytujący liczbę arabską od 1 do 3999 i wypisujący na ekranie jej odpowiednik rzymski.*/
        {
            int a;
            Console.WriteLine("Podaj liczbę");
            a = Convert.ToInt32(Console.ReadLine());
            if ((a < 4000) & (a > 3000))
            {
                Console.Write("MMM");
                if ((a < 4000) & (a > 3000))
            }
            else if ((a < 3000) & (a > 2000))
            {
                Console.Write("MM");
            }
        }
    }
}
