using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaneOsobowe
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a;

            //Osoba osoba1;
            Osoba osoba_1 = new Osoba();
            osoba_1.imie = "Jan";
            osoba_1.nazwisko = "Kowalski";
            osoba_1.wiek = 30;

            Osoba osoba_2 = new Osoba();
            osoba_2.imie = "Paweł";
            osoba_2.nazwisko = "Nowak";
            osoba_2.wiek = 15;
            
            Osoba osoba_3 = osoba_2;

            Osoba osoba_4 = osoba_1;
            osoba_4.imie = "Kamil";


            Console.WriteLine("Osoba 1: " + osoba_1.imie + " " + osoba_1.nazwisko + " " + osoba_1.wiek);
            Console.WriteLine("Osoba 2: " + osoba_2.imie + " " + osoba_2.nazwisko + " " + osoba_2.wiek);
            Console.WriteLine("Osoba 3: " + osoba_3.imie + " " + osoba_3.nazwisko + " " + osoba_3.wiek);
            Console.WriteLine("Osoba 4: " + osoba_4.imie + " " + osoba_4.nazwisko + " " + osoba_4.wiek);
            
            Osoba osoba_5 = new Osoba();

            Console.WriteLine("Podaj imie:");
            //std::cin >> osoba_5.imie;
            osoba_5.imie = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko:");
            osoba_5.nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj wiek:");
            string wiekString = Console.ReadLine();
            byte wiek = byte.Parse(wiekString);
            /*if (wiek < 130)
                osoba_5.wiek = wiek;*/

            osoba_5.SetWiek(wiek);
            osoba_5.Wiek = wiek;

            Console.WriteLine("Osoba 5: " + osoba_5.imie + " " + osoba_5.nazwisko + " " + osoba_5.GetWiek());
            Console.WriteLine("Osoba 5: " + osoba_5.imie + " " + osoba_5.nazwisko + " " + osoba_5.Wiek);

            Console.ReadLine();

        }
    }
}
