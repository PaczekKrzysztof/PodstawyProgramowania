using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)//Napisać program wczytujący imię użytkownika i wypisujący na ekranie tekst "Witaj imię!".
        {
            Console.WriteLine("Podaj swoje imie");
            string Imie = Console.ReadLine();
            Console.WriteLine("Witaj {0}!",Imie);//{0} wartość, która podasz po przecinku "0" to pierwsza, 1 to druga itd..
            Console.ReadKey(true);
          
        }
    }
}
