using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3___WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)/*Napisz program wczytujący dwie liczby całkowite a oraz b (a<b) i obliczający sumę kolejnych
liczb całkowitych począwszy od liczby a, a skończywszy na liczbie b. Obliczoną sumę wypisz
na ekranie. Użyj pętli while. Np. dla a=-2 i b=5 obliczamy sumę (-2)+(-1)+0+1+2+3+4+5.*/
        {
            int a, b, i,suma = 0;
            Console.WriteLine("Podaj a i b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            i = a;

            while (i<=b)
            {
                suma += i;
                
                i++;
            }
            Console.WriteLine("Suma kolejnych liczb natyralnych od {0} do {1} wynosi {2}", a, b, suma);
            Console.ReadKey(true);
        }
    }
}
