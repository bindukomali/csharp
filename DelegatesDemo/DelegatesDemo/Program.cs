using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    // Delegate Definition
    public delegate int operation(int x, int y);

    class Program
    {
        //Method that is passes as a Argument
        // It has same signature as Delegates
        static int Addition(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            //Delegate instantiation
            operation obj = new operation(Program.Addition);

            // output
            Console.WriteLine("Addition is={0}",obj(23,27));

            int result = obj.Invoke(50, 25);
            Console.WriteLine("Addition is={0}", result);
            Console.ReadLine();
        }
    }
}
