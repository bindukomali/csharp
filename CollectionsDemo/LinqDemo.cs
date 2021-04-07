using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LinqDemo
    {
        static void Main()
        {
            // Define LINQ Data source

            List<int> myIntegerList = new List<int>()
            {
                1,2,3,44,5,33,77,6,9
            };

            //LINQ Query using the Query Syntax

            var qry = from i in myIntegerList
                      where i > 10
                      select i;

            // Execution 
            foreach(var item in qry)
            {
                Console.Write(item + " ");
                
            }
            Console.WriteLine();


            //LINQ Query using Method Syntax
            var methodQry = myIntegerList.Where(i => i < 5).ToList();
            Console.WriteLine("*************************");
            // Execution
            foreach (var item in methodQry)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();
            Console.WriteLine("*************************");

            //LINQ Query using Mixed Syntax
            var mixedQry = (from i in myIntegerList
                            where i > 5
                            select i).Sum();

            Console.WriteLine("The sum is {0}", mixedQry);
            Console.ReadKey();
        }
    }
}
