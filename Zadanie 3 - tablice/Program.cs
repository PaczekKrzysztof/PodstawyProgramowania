using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3___tablice
{
    internal class Program
    {
        static void Main(string[] args)/*. Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych, sortujący je niemalejąco i
wypisujący posortowane liczby na ekranie.*/
        {
            int[] tablica = new int[1000]; //tablica z 1000 int'ów
            int i, j;
            int n, tmp;
            Console.Write("Podaj liczbę elementów n ");
            n = Convert.ToInt32(Console.ReadLine());//mamy teraz ilość tych elementów n
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj tablica[{0}]=", i);
                tablica[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
                for (j = i + 1; j < n; j++)
                    if (tablica[i] > tablica[j])
                    { tmp = tablica[i]; tablica[i] = tablica[j]; tablica[j] = tmp; }
            Console.Write("Elementy tablicy:");
            for(i = 0; i<n;i++)
            { Console.Write("{0}, ", tablica[i]); }
            Console.ReadKey(true);

        }
    }
}
