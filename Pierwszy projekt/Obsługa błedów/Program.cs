using System;

namespace Obsługa_błedów
{
    class Program
    {
        static int Iloraz(int a, int b)
        {
            int c;
            c = a / b;
            return c;
        }

        static void Main(string[] args)
        {
            int x, y, wynik;
            try
            {
                Console.WriteLine("Podaj x");
                string xStr = Console.ReadLine();
                x = int.Parse(xStr);

                Console.WriteLine("Podaj y");
                y = int.Parse(Console.ReadLine());

                wynik = x / y;
                //wynik = Iloraz(x, y);

                Console.WriteLine("Wynik " + wynik);
            }
            catch(Exception ex)
            {
                //.....
            }

            Console.ReadLine();
        }
    }
}
