using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class DataStore<T>     // generic class
    {
        public T Data { get; set; }     // generic property

        public DataStore(T val)
        {
            Console.WriteLine(val);        // generic constructor
        }
    }
    class GenericClassDemo
    {
        static void Main()
        {
            DataStore<string> store = new DataStore<string>("C# Genrics");
            store.Data = "Hello World";

            DataStore<int> store1 = new DataStore<int>(500);
            store1.Data = 100;
            Console.WriteLine(store.Data + " " + store.Data);
            Console.ReadKey();
        }
    }
}
