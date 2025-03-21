using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6___pętla
{
    class Program
    {
        static void Main(string[] args) /*Wczytaj liczbę naturalną n (n>1). Narysuj na ekranie z gwiazdek trójkąt równoramienny, który
nie jest trójkątem prostokątnym. Użyj pętli for.*/
        {
            int a, i,j,k,l,m;
            Console.WriteLine("Podaj liczbę mordo");
            a = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=a;i++)
            {
                for (j = 1; j <= a - 1; j++) Console.Write(" ");
                for (k = ; k <= a; k++) ; Console.Write("*");
                for (l = 1; l <= a; l++) ; Console.WriteLine("");





            }
            Console.ReadKey(true);


        }
    }
}
