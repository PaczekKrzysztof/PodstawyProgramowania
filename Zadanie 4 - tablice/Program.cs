using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4___tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[1000]; //tablica z 1000 int'ów
            int i;
            int n, suma;
            Console.Write("Podaj liczbę elementów n ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=0; i<n; i++)
            {
                Console.Write("Podaj tablica[{0}]=", i);
                44tablica[i] = Convert.ToInt32(Console.ReadLine());
            }
            suma = 0;
            for (i = 0; i < n; i++) suma += tablica[i];
            Console.Write("Suma elementów tablicy wynosi {0} ", suma);
            Console.ReadKey(true);

        }
    }
}
