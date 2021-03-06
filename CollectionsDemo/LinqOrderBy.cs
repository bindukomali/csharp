using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LinqOrderBy
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 10, 45, 35, 29, 100, 69, 58, 50 };
            Console.WriteLine("Before Sorting : ");
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            //Sorting the data in Ascending Order
            //Using Method Syntax
            var MS = intList.OrderBy(num => num);
            var MS1 = intList.OrderByDescending(num => num);
            //Using Query Syntax
            var QS = (from num in intList
                      orderby num
                      // orderby num descending
                      select num).ToList();
            Console.WriteLine();
            Console.WriteLine("After Sorting : ");
            foreach (var item in QS)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("After Sorting in Descending Order: ");
            foreach (var item in MS1)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
