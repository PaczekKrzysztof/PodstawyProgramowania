using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3___funkcje
{
    internal class Program
    {
        static double polekola(double r)
        {
            return (Math.PI * r * r);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Pole kola o promieniu 7 wynosi {0}", polekola(7));
            Console.ReadKey(true);
        }


    }
}
