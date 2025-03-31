using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5___tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[1000]; //tablica z 1000 int'ów
            int i = 0, j, liczba;
            Console.Write("Podaj liczbę naturalną: ");
            liczba = Convert.ToInt32(Console.ReadLine());
            while ((liczba/2!=0) || ((liczba/2==0) && (liczba%2!=0)))
            {
                tablica[i++] = liczba % 2;
                liczba /= 2;
            }
            for (j = i - 1; j >= 0; j--) Console.Write(tablica[j]);
            Console.ReadKey(true);
        }

    }
}
