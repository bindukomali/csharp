using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    // stores data in form of type of generic key, value pairs
    class DictionaryExample
    {
        static void Main()
        {
            Dictionary<int, String> names = new Dictionary<int, string>();

            names.Add(101, "Raj");
            names.Add(102, "Mike");
            names.Add(103, "Mary");
            names.Add(104, "John");
            names.Add(105, "Ravi");

            foreach(KeyValuePair<int,string> kv in names)
            {
                Console.WriteLine(kv.Key + "-" + kv.Value);
            }

            Console.WriteLine(names[102]);   // display based on key

            names.Remove(104);     /// Remove data based on key

            foreach(int k in names.Keys)
            {
                Console.WriteLine(k + " - " + names[k]);
            }

            Console.ReadKey();
        }
    }
}
