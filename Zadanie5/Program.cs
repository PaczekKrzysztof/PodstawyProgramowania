using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)//Napisać program wczytujący promień podstawy (r) i wysokość (h) stożka i wypisujący na ekranie objętość i pole całkowite tego stożka.
        {
            double r;
            double h;
            double l;
            Console.WriteLine("Podaj długość promienia r");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj długość wysokości h");
            h = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt(r * r + h * h);
            Console.WriteLine("Objętość tego stożka wynosi: {0}", Math.PI*r*r*h/3);
            Console.WriteLine("Pole całkowite tego stożka wynosi: {0}", Math.PI * r * (r + l));
            Console.ReadKey(true);
        }
    }
}
