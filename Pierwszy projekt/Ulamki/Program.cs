using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulamki
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double liczba1 = 0.3333;
            double liczba2 = 0.75;
            double liczba3;

            //liczba3 = liczba1 * liczba2; // 0.3333 * 0.75 = 0.249975

            Console.WriteLine(liczba3);*/

            double a = 5;
            double b = 8;
            double c = 0.5;

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                //dwa miejsca zerowe
            }
            else if (delta == 0)
            {
                //jedno miejsce zerowe
            }
            else
            {
                //brak miejsc zerowych
            }

            /*string test;
            if (delta > 0)
                test = "Dodatnia";
            else
                test = "Ujemna";

            //(warunek)?(wartosc1):(wartosc2);
            test = (delta > 0) ? "Dodatnia" : "Ujemna";

            Console.WriteLine(test);*/

            //-----------------------------------

            /*Ulamek u1 = new Ulamek(1, 3);
            Ulamek u2 = new Ulamek(3, 4);
            Ulamek u3;

            //u3 = u1 * u2; //1/3 * 3/4 => 3/12

            Console.WriteLine(u3);*/     
           
            Ulamek uA = new Ulamek(5, 1);
            Ulamek uB = new Ulamek(8, 1);
            Ulamek uC = new Ulamek(1, 2);
            Ulamek u4 = 4;

            int liczba = u4;

            Ulamek uDelta = uB * uB - 4 * uA * uC;          

            Ulamek u0 = new Ulamek(0, 1);
            if (uDelta > 0)
            {
                //dwa miejsca zerowe
            }
            else if (uDelta == 0)
            {
                //jedno miejsce zerowe
            }
            else
            {
                //brak miejsc zerowych
            }


            Console.ReadLine();
        }
    }
}
