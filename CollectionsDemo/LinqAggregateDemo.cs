using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LinqAggregateDemo
    {
        static void Main()
        {
            // Define LINQ Data Source

            List<int> myIntegerList = new List<int>()
            {
                1,2,3,44,5,33,77,6,9
            };

            int m = myIntegerList.Min();
            int n = myIntegerList.Max();
            double k = myIntegerList.Average();
            int s = myIntegerList.Sum();
            int c = myIntegerList.Count();

            /* Aggregate function is useful to perform the operations on each item of the list.
             * The Aggregate() function will perform the action on the first and second elements
             * and then carry forward the result. */
            double ag = myIntegerList.Aggregate((a, b) => a * b);

            Console.WriteLine("The Minimum no. in List is {0}", m);
            Console.WriteLine("The Maximum no. in List is {0}", n);
            Console.WriteLine("The Average no. in List is {0}", k);
            Console.WriteLine("The Total nos in List is {0}", c);
            Console.WriteLine("The Sum of nos in List is {0}", s);
            Console.WriteLine("The Sum of series in the List is {0}", ag);
            Console.WriteLine("The Multiplication of Nos in the List is {0}", ag);

            string[] charlist = { "a", "b", "c", "d" };
            var concat = charlist.Aggregate((a, b) => a + ',' + b);
            Console.WriteLine("Concatenated String: {0}", concat);

            Console.ReadKey();
        }
    }
}
