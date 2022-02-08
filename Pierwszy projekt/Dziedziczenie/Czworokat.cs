using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Czworokat
    {
        private string nazwa;
        protected float bokA, bokB, bokC, bokD;
        
        private float obwod;
        protected float pole;

        //public Czworokat()
        //{

        //}

        public Czworokat(string n, float a, float b, float c, float d)
        {
            nazwa = n;
            bokA = a;
            bokB = b;
            bokC = c;
            bokD = d;
            obwod = 0;
            pole = 0;
        }

        public void Info()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Obiekt o nazwie " + nazwa);
            Console.WriteLine("Bok a = " + bokA);
            Console.WriteLine("Bok b = " + bokB);
            Console.WriteLine("Bok c = " + bokC);
            Console.WriteLine("Bok d = " + bokD);
            Console.WriteLine("Obwod = " + obwod);
            Console.WriteLine("Pole = " + pole);
            Console.WriteLine("----------------------------------");
        }

        public void ObliczObwod()
        {
            obwod = bokA + bokB + bokC + bokD;
        }

    }
}
