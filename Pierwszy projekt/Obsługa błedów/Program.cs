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
            int x = 0, y = 0, wynik;
            bool powtorzyc = false;
            do
            {
                try
                {
                    powtorzyc = false;
                    Console.WriteLine("Podaj x");
                    string xStr = Console.ReadLine();
                    x = int.Parse(xStr);

                    Console.WriteLine("Podaj y");
                    y = int.Parse(Console.ReadLine());

                    wynik = x / y;
                    //wynik = Iloraz(x, y);

                    Console.WriteLine("Wynik " + wynik);
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine("Bład: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bład: " + ex.Message);
                    powtorzyc = true;
                }
            } while (powtorzyc == true);


            Console.ReadLine();
        }
    }
}
