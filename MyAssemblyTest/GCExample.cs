using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssemblyTest
{
    class GCExample
    {
        public static void Main()
        {
            Console.WriteLine("hello World");
            Console.WriteLine("GC Maximum Generations :" + GC.MaxGeneration);
            Console.ReadKey();
        }
    }
}
