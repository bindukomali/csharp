using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class People   // internal -- can be accessed within assembly/ns
    {
        public People()
        {
            Console.WriteLine("Constructor Invoked");
        }

        ~People()
        {
            Console.WriteLine("Destructor Invoked");
        }
    }
    class DestructorDemo
    {
        static void Main()
        {
            People p1 = new People();
            People p2 = new People();
            People p3 = new People();
           // Console.ReadKey();
        }
    }
}
