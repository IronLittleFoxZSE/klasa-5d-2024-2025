using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf04_2022_06_02ConsoleApp
{
    public class Person
    {
        private int id;
        private string name;

        public static int count = 0;
        /*public Person() : this(0, "")
        {
            //id = 0;
            //name = "";
            //count++;
        }*/
        public Person(int id = 0, string name = "")
        {
            this.id = id;
            this.name = name;
            count++;
        }

        public Person(Person p) : this(p.id, p.name)
        {
            //id = p.id;
            //name = p.name;
            //count++;
        }

        public void Show(string name)
        {
            if (this.name != "")
                Console.WriteLine($"Cześć {name}, mam na imię {this.name}");
            else
                Console.WriteLine("Brak danych");
        }
    }
}
