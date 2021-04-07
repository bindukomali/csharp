using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SingleInheritance
    {
        static void Main(string[] args)
        {
            //create 5 yr old mammal
            Mammal mammel = new Mammal(5);
            Console.WriteLine(mammel.Age);
            mammel.Sleep();



            // create a bulldog, 3 yr old
            Dog dog = new Dog("Bulldog", 3);
            dog.Sleep();
            dog.Age = 4;
            Console.WriteLine("Age: {0}", dog.Age);
            Console.WriteLine("Breed: {0}", dog.Breed);
            dog.WagTail();






            Console.ReadKey();
        }
    }
}
