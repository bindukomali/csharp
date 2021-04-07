using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Pass By Value to Methods Example
namespace OOPsDemo
{
    class MethodsDemo
    {
        public static void Multiplication(int x)
        {
            x *= x;
            Console.WriteLine("Variable value Inside Method {0}", x);
        }

        public static void Multiplication1(ref int x)
        {
            x *= x;
            Console.WriteLine("Variable value Inside Method {0}", x);
        }

        public static void Multiplication2(out int x)
        {
            x = 10;    // out type should be initialized in method itself.
            x *= x;
            Console.WriteLine("Variable value Inside Method {0}", x);
        }
        static void Main()
        {
            int a = 10;
            int b;

            Console.WriteLine("--------------- Pass By Value -----------------");
            Console.WriteLine("The Value of A before method call {0}", a);
            Multiplication(a);    // Passing parameters By Value
            Console.WriteLine("The Value of A After method call {0}", a);

   /* In c#, passing a value type parameter to a method by reference means passing a
    * reference of the variable to the method.
    * So the changes made to the parameter inside of the called method will have an
    * effect on the original data stored in the argument variable. */
            Console.WriteLine("--------------- Pass By Reference -----------------");
            Console.WriteLine("The Value of A before method call {0}", a);
            Multiplication1(ref a);   // Passing parameters By Reference
            Console.WriteLine("The Value of A After method call {0}", a);

    /* In c#, out keyword is used to pass arguments to the method as a reference type.
     * The out keyword same as the ref keyword but the only difference is out doesn’t
     * require a variable to be initialized before we pass it as an argument to the
     * method but the variable must be initialized in called method before it returns a
     * value to the calling method. */
            Console.WriteLine("--------------- Pass By Out -----------------");
            Multiplication2(out b);   // Passing parameters By Reference
            Console.WriteLine("The Value of B After method call {0}", b);
            Console.ReadKey();
        }
    }
}
