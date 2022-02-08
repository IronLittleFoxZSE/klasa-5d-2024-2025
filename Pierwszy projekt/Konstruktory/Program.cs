using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //TestKonstruktorow test(5);
                TestKonstruktorow test = new TestKonstruktorow(5);
                
                test.TestowaMetoda();
                test = null;
                GC.Collect();
                //delete test;
            }
            GC.Collect();
            Console.ReadLine();
        }
    }
}
