using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo3
{
    class TestNameSpace
    {
        static void Main()
        {
            Computer.Hardware h1 = new Computer.Hardware();
            Television.Hardware h2 = new Television.Hardware();

            h1.test();
            h2.test();
            Console.ReadKey();
        }
    }
}
