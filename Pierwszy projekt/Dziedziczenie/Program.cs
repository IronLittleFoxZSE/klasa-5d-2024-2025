using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {

            Czworokat czworokat = new Czworokat("czworokat", 1, 2, 3, 4);
            czworokat.ObliczObwod();
            czworokat.Info();

            Prostakat prostokat = new Prostakat("prostokat", 2, 5);
            prostokat.ObliczObwod();
            prostokat.ObliczPole();
            prostokat.Info();

            Trapez trapez = new Trapez("trapez", 1, 2, 3, 4, 5);
            trapez.ObliczObwod();
            trapez.ObliczPole();
            trapez.Info();

            Kwadrat kwadrat = new Kwadrat("kwadrat", 2);
            kwadrat.ObliczObwod();
            kwadrat.ObliczPole();
            kwadrat.Info();

            Console.ReadLine();
        }
    }
}
