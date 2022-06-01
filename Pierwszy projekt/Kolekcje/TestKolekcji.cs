using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    class TestKolekcji
    {
        public void TestTablic()
        {
            // C/C++
            // int tablicaStatyczna[10];
            // int* tablica = new int[10];

            // C#
            int[] tablicaLiczb;
            tablicaLiczb = new int[10];

            Random rand = new Random();
            for (int i=0; i < tablicaLiczb.Length; i++)
            {
                tablicaLiczb[i] = rand.Next(1, 100);
            }




        }

    }
}
