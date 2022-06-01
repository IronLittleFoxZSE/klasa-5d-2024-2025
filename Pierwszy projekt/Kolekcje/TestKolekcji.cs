using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
    }


    class TestKolekcji
    {
        public void TestTablic()
        {
            // C/C++
            // int tablicaStatyczna[10];
            // int* tablica = new int[10];
            // //tablica = null;
            // delete tablica;

            // C#
            int[] tablicaLiczb;
            tablicaLiczb = new int[10];

            Random rand = new Random();
            for (int i = 0; i < tablicaLiczb.Length; i++)
            {
                tablicaLiczb[i] = rand.Next(1, 100);
            }

            Console.WriteLine("Wyświetlenie zawartości tablicy:");

            foreach (int element in tablicaLiczb)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();

            SortujTablice(tablicaLiczb);

            Console.WriteLine("Wyświetlenie posortowanej zawartości tablicy:");

            foreach (int element in tablicaLiczb)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();

        }

        private void SortujTablice(int[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
                for (int j = 0; j < tablica.Length - 1 - i; j++)
                    if (tablica[j] > tablica[j + 1])
                    {
                        int tmp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = tmp;
                    }
        }

        public void TestTablicObiekty()
        {
            Osoba[] tablicaOsob = new Osoba[3];
            tablicaOsob[0] = new Osoba();
            tablicaOsob[1] = new Osoba();
            tablicaOsob[2] = new Osoba();

            tablicaOsob[0].Imie = "Adam";
            tablicaOsob[0].Nazwisko = "Nowak";
            tablicaOsob[0].Wiek = 30;

            tablicaOsob[1].Imie = "Ewa";
            tablicaOsob[1].Nazwisko = "Kowalska";
            tablicaOsob[1].Wiek = 15;

            tablicaOsob[2].Imie = "Jan";
            tablicaOsob[2].Nazwisko = "Nieznany";
            tablicaOsob[2].Wiek = 25;

            Console.WriteLine("");
        }

    }
}
