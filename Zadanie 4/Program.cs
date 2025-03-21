using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args) /*Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt
posiadający n wierszy i k kolumn. Użyj pętli for.*/
        {
            int a, b, i,j;
            Console.WriteLine("Podaj dwie liczby naturalne");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for (i=1;i<=a;i++)
            {
                for (j = 1; j <= b; j++)
                
                  Console.Write("*");
                  Console.WriteLine("");
                    
                
            }
            Console.ReadKey(true);
        }
    }
}
