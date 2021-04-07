using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     public class Mammal
    {
        private int age;



        public Mammal(int age)
        {
            this.age = age;
        }



        public int Age { get { return age; } set { age = value; } }



        public void Sleep()
        {
            Console.WriteLine("Shhh! I'm sleeping!");
        }
    }
}
