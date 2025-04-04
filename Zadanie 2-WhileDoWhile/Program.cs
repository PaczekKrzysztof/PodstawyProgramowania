using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)/*Dany jest wzór ciągu a(n)=2n-1. Napisz program wczytujący liczbę całkowitą dodatnią n i
wypisujący na ekranie kolejne wyrazy ciągu: a(1), a(2), …, a(n). Użyj pętli while.*/
        {
            int n,i,an;
            Console.WriteLine("Podaj n");
            n = Convert.ToInt32(Console.ReadLine());
            i = 1;
                while (i<=n)
            {
                an = 2 * i - 1;
                Console.WriteLine("a({1}) = {0} ", an,i);
                i++;
                
                ;

            }


        }
    }
}
