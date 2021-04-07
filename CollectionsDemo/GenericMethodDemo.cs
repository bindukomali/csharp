using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
 
        public class GenericClass<T>
        {
            public T msg;
            public void genericMethod(T name,T location)
            {
                Console.WriteLine("{0}",msg);
                Console.WriteLine("Name: {0}", name);
                Console.WriteLine("Location: {0}", location);
            }
        }

    class GenericMethodDemo
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("******Generics Example******");
            // Instantiate Generic Class, string is the type argument
            GenericClass<string> gclass = new GenericClass<string>();
            gclass.msg = "Welcome to C#";
            gclass.genericMethod("Bill gates", "California");
            Console.ReadLine();
        }
    }
}
