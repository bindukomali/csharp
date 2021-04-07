using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LambdaDemo
    {
        int rollNo;
        String name;

        public int RollNo { get => rollNo; set => rollNo = value; }
        public string Name { get => name; set => name = value; }

        public static void Main()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);

            foreach (var num in evenNumbers)
            {
                Console.Write("{0} ", num);
            }
            // lambda exp to calculate square of each value in the list
            var square = list.Select(x => x * x);
            Console.WriteLine("************** Squares ***************");

            foreach (var num in square)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
