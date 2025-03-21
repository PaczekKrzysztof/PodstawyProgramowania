using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5___pętla
{
    class Program
    {
        static void Main(string[] args) /*Wczytaj liczbę naturalną n (n>1). Narysuj na ekranie z gwiazdek trójkąt prostokątny. Użyj
pętli for. Przykładowo dla n=3 narysowany trójkąt powinien wyglądać:*/
        {
            int i, a, b;
            Console.WriteLine("Podaj liczbe naturalną");
            a = Convert.ToInt32(Console.ReadLine());
            for (i=1;i<=a;i++)
            {
                for (b = 1; b <= i; b++)
                    Console.Write("*");
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        } 
    } 
}
