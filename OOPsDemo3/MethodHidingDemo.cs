using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo3
{
    class SuperClass
    {
        public void display()
        {
            Console.WriteLine("Base Class Display Method");
        }
    }
    class DerivedClass : SuperClass
    {
        public new void display()
        {
            Console.WriteLine("Derived Class Display Method");
        }
    }
    class MethodHidingDemo
    {
        static void Main()
        {
            DerivedClass d1 = new DerivedClass();
            d1.display();
            Console.ReadKey();
        }
    }
}
