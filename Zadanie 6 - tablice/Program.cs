using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6___tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dni = new string[] { "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela" };
            foreach (string elem in dni)
                Console.Write("{0}, ", elem);
            Console.ReadKey(true);
        }
    }
}
