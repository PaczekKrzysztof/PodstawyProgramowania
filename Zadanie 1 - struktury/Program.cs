using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1___struktury /*Zdefiniuj strukturę o nazwie Osoba posiadającą trzy pola: imie, nazwisko i rok_urodzenia.
Zadeklaruj zmienną typu strukturalnego o nazwie o, wczytaj do niej wszystkie wartości pól od
użytkownika i wypisz wszystkie pobrane wartości pól na ekranie.*/
{
    struct Osoba
    {
        public string imie, nazwisko;
        public int rok_uro;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o;
            Console.WriteLine("Podaj imię mordo");
            o.imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko");
            o.nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj rok urodzenia");
            o.rok_uro =Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("{0} {1} urodził się {2} roku", o.imie, o.nazwisko, o.rok_uro);
            Console.ReadKey(true);

        }
    }
}
