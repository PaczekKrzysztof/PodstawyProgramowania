using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4___WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)/*Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt
posiadający n wierszy i k kolumn. Użyj pętli while. Dla n=3 i k=5 mamy:*/
        {
            int wiersze, kolumny,i,a = 0,b = 0;
            Console.WriteLine("Podaj liczbę wierszy:");
            wiersze = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę kolumn:");
            kolumny = Convert.ToInt32(Console.ReadKey());
            while (i<=kolumny)
            {
                Console.Write("*");
            }





        }
    }
}
