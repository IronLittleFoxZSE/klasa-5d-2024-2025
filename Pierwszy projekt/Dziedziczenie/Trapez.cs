using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Trapez : Czworokat
    {
        private float wysokosc;

        public Trapez(string n, float a, float b, float c, float d, float w) : base(n, a, b, c, d)
        {
            wysokosc = w;
        }

        public void ObliczPole()
        {
            pole = (bokB + bokD) * wysokosc / 2;
        }
    }
}
