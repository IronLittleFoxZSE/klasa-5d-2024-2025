using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory
{
    class TestKonstruktorow
    {

        //tryb_ochrony typ_Zwracany nazwa_Metody (parametry)
        
        public TestKonstruktorow()
        {
            Console.WriteLine("Teraz dziala konstruktor bez parametrów");
        }

        public TestKonstruktorow(int x)
        {
            Console.WriteLine("Teraz dziala konstruktor z parametrem");
        }

        ~TestKonstruktorow()
        {
            Console.WriteLine("Teraz dziala destruktor");
        }

        public void TestowaMetoda()
        {
            Console.WriteLine("Teraz działa metoda testowa");
        }
    }
}
