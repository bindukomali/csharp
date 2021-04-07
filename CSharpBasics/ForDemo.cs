using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class ForDemo
    {
        public static void Main(String[] args)
        {
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine("C# For Loop: Iteration {0}", i);
            }

            //multiple intialization & iterator expressions

            for(int i=0,j=0; i+j<=5; i++,j++)
            {
                Console.WriteLine("i = {0} and j ={1}", i, j);
            }

            // for loop without intializations & iterator statements
            int m = 1;
            for(; m<=5; )
            {
                Console.WriteLine("C# For Loop: Iteration {0}", m);
                m++;
            }

            // infinite Loops
            /* for(; ; )
             {
                 Console.WriteLine("Infinte Loop");
             }*/
            Console.ReadKey();
        }
    }
}
