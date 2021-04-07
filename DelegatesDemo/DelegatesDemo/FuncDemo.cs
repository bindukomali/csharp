using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class FuncDemo
    {
        static Func<int, int, int> operation;

        public static int Sum(int x,int y)
        {
            return x + y;
        }

        public static void Main()
        {
            Func<int, int, int> add = Sum;

            int result = add(10, 20);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
