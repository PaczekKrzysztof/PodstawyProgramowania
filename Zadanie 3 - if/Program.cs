using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3___if
{
    internal class Program
    {
        static void Main(string[] args) //Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i
//największej z tych liczb.
        {
            int a, b, c;
            Console.WriteLine("Podaj 3 liczby mordo");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if ((a >= b) & (a>=c) & (b>=c))
                Console.WriteLine("Największa liczba to {0}, a najmniejsza to {1}",a,c );
            
            if ((a >= b) & (a >= c) & (c >= b))
                Console.WriteLine("Największa liczba to {0}, a najmniejesza to {1}", a,b);
            
            if ((b >= a) & (b >= c) & (a >= c))
                Console.WriteLine("Największa liczba to {0}, a najmniejesza to {1}", b,c);
       
            if ((b >= c) & (b >= a) & (c >= a))
                Console.WriteLine("Największa liczba to {0}, a najmniejesza to {1}", b,a);
            
            if ((c >= b) & (c >= a) & (a >= b))
                Console.WriteLine("Największa liczba to {0}, a najmniejesza to {1}", c,b);
            
            if ((c >= b) & (c >= a) & (b >= a))
                Console.WriteLine("Największa liczba to {0}, a najmniejesza to {1}", c,a);
            
            Console.ReadKey();
        }
    }
}
