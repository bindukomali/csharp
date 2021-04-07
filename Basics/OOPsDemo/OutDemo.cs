using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    class OutDemo
    {
        static void Main(string[] args)
        {
            //The out parameter in c# is also useful to return more than one value from the methods in c# programming language.

            int x, y;
            Multiplication(out x, out y);
            Console.WriteLine("x Value: {0}", x);
            Console.WriteLine("y Value: {0}", y);

            Console.ReadKey();
        }

        public static void Multiplication(out int a, out int b)
        {
            a = 10;
            b = 5;

            a *= a;
            b *= b;

        }
    }
}
