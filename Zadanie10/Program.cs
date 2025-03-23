using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    class Program
    {
        static void Main(string[] args)// Napisać program wczytujący promień koła i wypisujący na ekranie jego pole i obwód.
        {
            double r,P,obw;
            Console.WriteLine("Podaj długość promienia");
            r = Convert.ToDouble(Console.ReadLine());
            P = Math.PI * r * r;
            obw = Math.PI * r * 2;
            Console.WriteLine("Pole tego koła wynosi {0}, a obwód {1}", P, obw);
            Console.ReadKey(true);
            

        }
    }
}
