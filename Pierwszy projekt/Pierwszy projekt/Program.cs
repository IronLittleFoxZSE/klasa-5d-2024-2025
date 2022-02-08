using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pierwszy_projekt
{
    class Program
    {
        //void main(int rozmiar, string[] tablica)
        static void Main(string[] args)
        {
            //std::cout << "Hello world" << std::endl;         
            //std::cout << "Hello\nworld\n";         
            //std::cout << "Hello" << std::endl << "world\n";         

            Console.WriteLine("Hello world");

            //typ_zmiennej nazwa_zmiennej;
            string imie = "Jan";
            string nazwisko = "Kowalski";

            //std::cout << "Nazywam sie " << imie << " " << nazwisko << "\n";
            //string dana = "Nazywam sie " + imie;  //"Nazywam sie Jan"
            //std::cout <<( "Nazywam sie " + imie + " " + nazwisko + "\n");
            Console.WriteLine("Nazywam sie " + imie + " " + nazwisko);
            Console.WriteLine("Nazywam sie {0} {1}", imie, nazwisko);
            Console.WriteLine($"Nazywam sie {imie} {nazwisko}");
            string dana = $"Nazywam sie {imie} {nazwisko}";

            Console.WriteLine("Prędkość to km\\h");
            Console.WriteLine(@"Prędkość to km\h");

            int a, b;
            a = 8;
            b = 2;

            if (a > b)
                Console.WriteLine("Największa a = " + a);
            else
                Console.WriteLine($"Największa b = {b}");


            int c;
            c = 12;
            if (a > b && a > c)
                Console.WriteLine("Największa a = " + a);
            else if (/* b > a && */ b > c)
                Console.WriteLine($"Największa b = {b}");
            else
                Console.WriteLine($"Największa c = {c}");

            //typ_zmiennej nazwa_zmiennej[rozmiar];
            //int tablica[5];
            //tablica[2] = 3;

            //tym_zmiennej[] nazwa_zmiennej;
            int[] tablica = new int[5];
            tablica[2] = 5;





            Console.ReadLine();
        }
    }
}
