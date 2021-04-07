using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssemblyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello for Testing My Assembly - Change Character");

            ChangeCharacter c1 = new ChangeCharacter();

            string u = c1.UpperCase("hello class library");
            string l = c1.LowerCase("THANKS Class LIB");

            Console.WriteLine("Using My Assembly methods");
            Console.WriteLine("Upper Case :" + u);
            Console.WriteLine("Lower Case :" + l);

            Console.ReadKey();
        }
    }
}
