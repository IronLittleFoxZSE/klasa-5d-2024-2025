using System;

namespace Przetwarzanie_numeru_pesel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer pesel");
            string numerPesel = Console.ReadLine();

            try
            {
                Pesel p = new Pesel(numerPesel);

                Console.WriteLine("Plec wlasciciela numeru:" + p.Plec);
                Console.WriteLine("Plec wlasciciela numeru:" + p.PlecOpisowa);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
