using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo3
{
    class Developer
    {
        public virtual void getInfo()   //  virtual methods should be overriden
        {
            Console.WriteLine("I am a Team Leader");
        }
    }

    class CSharpDeveloper:Developer
    {
        public override void getInfo()   //  virtual methods should be overriden
        {
            Console.WriteLine("I am a Team Leader");
        }

    }
    class OverRideDemo
    {
       static void Main()
        {
            CSharpDeveloper c1 = new CSharpDeveloper();
            c1.getInfo();

            Developer d1 = new Developer();
            d1.getInfo();
            Console.ReadKey();
        }
    }
}
