using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Prostakat : Czworokat
    {
        public Prostakat(string n, float a, float b) : base(n, a, b, a, b)
        {

        }

        public void ObliczPole()
        {
            pole = bokA * bokB;
        }
    }
}
