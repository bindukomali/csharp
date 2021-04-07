using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo3
{
    public class Animal
    {
        public virtual void eat() { Console.WriteLine("Eating........"); }
        public virtual void run() { Console.WriteLine("Running......."); }
    }

    public class Dog : Animal
    {
        public override void eat() { Console.WriteLine("Eating........"); }
        public sealed override void run() { Console.WriteLine("Running......."); }
    }

    class BabyDog:Dog
    {
        public override void eat() { Console.WriteLine("Eating Biscuits........"); }
        //  public override void run() { Console.WriteLine("Running Slowly......."); }
        public void run1() { Console.WriteLine("Running Slowly......."); }
    }
    class SealedMethodDemo
    {
        public static void Main()
        {
            BabyDog d = new BabyDog();
            d.eat();
            d.run();
           // d.run1();

        }

    }
}
