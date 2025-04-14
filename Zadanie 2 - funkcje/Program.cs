using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2___funkcje
{
    internal class Program/*Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistych
zadanych jako argumenty tej funkcji.Napisz program wykorzystujący funkcję max.*/
    {
        static int max(int a, int b)
        { if (a > b) return a;
            else return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Z liczb 69 i 420 większa jest {0}", max(69, 420));
            Console.WriteLine("Z liczb 69 i 420 większa jest {0}", max(420, 69));
            Console.WriteLine("Z liczb 69 i 420 większa jest {0}", max(69, 69));
            Console.ReadKey(true);
        }



    }
}
