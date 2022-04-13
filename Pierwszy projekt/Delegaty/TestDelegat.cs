using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    class TestDelegat
    {
        delegate int OperacjaDoWykonaniaDelegate(int x, int y);

        public void Test()
        {
            Console.WriteLine("Podaj pierwsza liczbe");
            string xStr = Console.ReadLine();
            int x = int.Parse(xStr);
            Console.WriteLine("Podaj druga liczbe");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj operacje do wykonania");
            char operacja = Console.ReadLine()[0];
            int wynik;

            //wersja pierwsza
            switch (operacja)
            {
                case '+':
                    wynik = Suma(x, y);
                    break;
                case '*':
                    wynik = Iloczyn(x, y);
                    break;
                default:
                    wynik = 0;
                    break;
            }
            WyswieltWynikOperacji(wynik, operacja);

            //wersja druga
            OperacjaDoWykonaniaDelegate operacjaDoWykonaniaDelegate;
            switch (operacja)
            {
                case '+':
                    operacjaDoWykonaniaDelegate = Suma;
                    break;
                case '*':
                    operacjaDoWykonaniaDelegate = Iloczyn;
                    break;
                default:
                    operacjaDoWykonaniaDelegate = null;
                    break;
            }

            if (operacjaDoWykonaniaDelegate != null)
                wynik = operacjaDoWykonaniaDelegate(x, y);
            else
                wynik = 0;

            WyswieltWynikOperacji(wynik, operacja);

        }

        private void WyswieltWynikOperacji(int wynik, char operacja)
        {
            Console.WriteLine("Wynik operacji "+ operacja + " to " + wynik);
        }

        private int Suma(int a, int b)
        {
            return a + b;
        }

        private int Iloczyn(int a, int b)
        {
            return a * b;
        }
    }
}
