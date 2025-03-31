using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1_tablice
{
    internal class Program
    {
        static void Main(string[] args)/*Napisać program wczytujący ciąg n(1 <= n <= 1000) liczb całkowitych(dodatnich i ujemnych) i
wypisujący wczytane liczby na ekranie.*/
        {
            int[] tablica = new int[1000]; //tablica z 1000 int'ów
            int i, n;
            Console.Write("Podaj liczbę elementów n ");
            n = Convert.ToInt32(Console.ReadLine());//mamy teraz ilość tych elementów n
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj tablica[{0}]=", i);
                tablica[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("elementy tablicy to:");
            for (i = 0; i < n; i++)
                Console.Write("{0}", tablica[i]);
            Console.ReadKey(true);
            





        }
    }
}
