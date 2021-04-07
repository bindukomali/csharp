using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssemblyTest
{
    class GCBase
    {
        void display()
        {
            Console.WriteLine("Test Method");
        }
    }
    class GCExample2
    {
        static void Main()
        {
            Console.WriteLine("Total Memory :" + GC.GetTotalMemory(false));
            GCBase g1 = new GCBase();

            Console.WriteLine("GCBase obj Generation is :" + GC.GetGeneration(g1));

            Console.WriteLine("Total Memory :" + GC.GetTotalMemory(false));

            GCBase g2 = new GCBase();
            Console.WriteLine("Total Memory :" + GC.GetTotalMemory(false));
            Console.ReadKey();
        }
    }
}
