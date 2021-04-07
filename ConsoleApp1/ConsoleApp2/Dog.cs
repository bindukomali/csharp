using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
       public class Dog : Mammal
    {
         
        private string breed;



        public Dog(string breed, int age) : base(age)
        {
            this.breed = breed;
        }



        public string Breed { get => breed; set => breed = value; }



        public void WagTail()
        {
            Console.WriteLine("Tail wagging...");
        }




    }
}

