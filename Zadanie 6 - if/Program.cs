using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6___if
{
    internal class Program
    {
        static void Main(string[] args) /* Napisać program wczytujący numer miesiąca (od 1 do 12) i wypisujący na ekranie nazwę tego
miesiąca. Użyj instrukcji wyboru switch.*/
        {
            int miesiac;
            Console.WriteLine("Podaj numer miesiąca");
            miesiac = Convert.ToInt32(Console.ReadLine());
            switch (miesiac)
            {
                case 1: Console.WriteLine("Ten miesiąc to styczeń"); break;
                case 2: Console.WriteLine("Ten miesiąc to luty"); break;
                case 3: Console.WriteLine("Ten miesiąc to marzec"); break;
                case 4: Console.WriteLine("Ten miesiąc to kwiecień"); break;
                case 5: Console.WriteLine("Ten miesiąc to maj"); break;
                case 6: Console.WriteLine("Ten miesiąc to czerwiec"); break;
                case 7: Console.WriteLine("Ten miesiąc to lipiec"); break;
                case 8: Console.WriteLine("Ten miesiąc to sierpień"); break;
                case 9: Console.WriteLine("Ten miesiąc to wrzesień"); break;
                case 10: Console.WriteLine("Ten miesiąc to październik"); break;
                case 11: Console.WriteLine("Ten miesiąc to listopad"); break;
                case 12: Console.WriteLine("Ten miesiąc to grudzień"); break;
                default: Console.WriteLine("Nie ma takiego miesiąca"); break;
            }
            Console.ReadKey(true);
               
      


        }
    }
}
