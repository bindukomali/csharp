using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Add
    {
        public Add()
        {

        }

        public void addition<T>(T val1, T val2)
        {
            dynamic a = val1;
            dynamic b = val2;
            Console.WriteLine(a + b);

        }
    }
    class GenericAdd
    {
        static void Main()
        {
            Add a1 = new Add();
            a1.addition(10, 20);
            a1.addition(22.34f, 12.45f);
            a1.addition("Hello", "World");
            Console.ReadKey();

        }
    }
}
