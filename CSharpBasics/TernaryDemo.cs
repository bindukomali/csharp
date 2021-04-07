using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{ 
     /* Ternary operator are a substitute for if...else statement.
    
     Syntax : Condition ? Expression1 : Expression2;
    */

    class TernaryDemo
    {

        static void Main()
        {
            int number = 2;
            bool isEven;
            string a;

            isEven = (number % 2 == 0) ? true : false;
            Console.WriteLine(isEven);

            a = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine(a);

            int n1 = 20, n2 = 30;
            String b;

            b = n1 > n2 ? "N1 is Greater than N2" : n1 < n2 ?"N2 is Greater than N1"
                : "N1 is Equal to N2";
           
            Console.WriteLine(b);
            Console.ReadKey();

        }
    }
}
