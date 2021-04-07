using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class ArrayListDemo
    {
        static void Main()
        {
            ArrayList list = new ArrayList(); list.Add("Manesh");
            list.Add("Akshay");
            list.Add("Vikash");
            list.Add("Anuj");
            list.Add("Dharmesh");
            list.Add("Raman");

            Console.WriteLine("Initial ArrayList Contents:");
            foreach(string v in list)
            {
                Console.WriteLine(v);
            }
            list.Reverse();
            Console.WriteLine("ArrayList Contents after Reversing:");
            foreach (string v in list)
            {
                Console.WriteLine(v);
            }
            list.Sort();
            Console.WriteLine(list.BinarySearch("Raman"));   // searches in sorted AL
            Console.WriteLine("ArrayList Contents after Sorting:");
            foreach (string v in list)
            {
                Console.WriteLine(v);
            }

            Console.ReadKey();


        }
    }
}
