using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6___if
{
    class Program
    {
        static void Main(string[] args) //Napisać program wczytujący numer miesiąca (od 1 do 12) i wypisujący na ekranie nazwę tego miesiąca. Użyj instrukcji wyboru switch. 
        {
            int miesiąc;
            Console.WriteLine("Podaj numer miesiąca");
            miesiąc = Convert.ToInt32(Console.ReadLine());
            switch (miesiąc)
            {
                case 1: Console.WriteLine("{0} miesiąc to styczeń", miesiąc); break;
                case 2: Console.WriteLine("{0} miesiąc to luty", miesiąc); break;
                case 3: Console.WriteLine("{0} miesiąc to marzec", miesiąc); break;
                case 4: Console.WriteLine("{0} miesiąc to kwiecień", miesiąc); break;
                case 5: Console.WriteLine("{0} miesiąc to maj", miesiąc); break;
                case 6: Console.WriteLine("{0} miesiąc to czerwiec", miesiąc); break;
                case 7: Console.WriteLine("{0} miesiąc to lipiec", miesiąc); break;
                case 8: Console.WriteLine("{0} miesiąc to sierpień", miesiąc); break;
                case 9: Console.WriteLine("{0} miesiąc to wrzesień", miesiąc); break;
                case 10: Console.WriteLine("{0} miesiąc to paźdzernik", miesiąc); break;
                case 11: Console.WriteLine("{0} miesiąc to listopad", miesiąc); break;
                case 12: Console.WriteLine("{0} miesiąc to grudzień", miesiąc); break;
                default: Console.WriteLine("Mamy tylko 12 miesięcy, nie {0}", miesiąc); break;
                    Console.ReadKey(true);



            }
        }
    }
}
