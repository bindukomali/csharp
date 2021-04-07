using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class ImplicitTypeDemo
    {

        static void Main()
        {
            var b = 100;   // explicitly typed variable
            var a = 100;   // implicitly typed local variable
            var name = "Raj";
            var arr = new[] { 11, 22, 33 };

            Console.WriteLine(a + "-" + a.GetType());
            Console.WriteLine(name);
            Console.WriteLine(arr);

            /* a = "c#";
            var i;    // implicit variab;le should be intialised

            var j = 10, k = 30; */    // cannot declared implicit variables in a single stmt

            Console.ReadKey();

        }

       
    }
}
