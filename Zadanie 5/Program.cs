using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    class Program
    {
        static void Main(string[] args)//Napisać program wczytujący promień podstawy (r) i wysokość (h) stożka i wypisujący na ekranie objętość i pole całkowite tego stożka. 
        {
            double r, h, l, V, P;
            Console.WriteLine("Podaj promień podstawy i wysokość stożka:");
            Console.WriteLine("Promień podstawy:");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wysokość");
            h = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt((h * h) + (r * r));//Tworząca
            V = (Math.PI * r * r * h) / 3;
            P = (Math.PI * r * r) + (Math.PI * r * l);
            Console.WriteLine("Objętość stożka wynosi {0}, a pole całkowite {1}", V, P);
        }
    }
}
