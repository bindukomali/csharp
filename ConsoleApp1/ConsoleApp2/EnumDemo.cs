using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class EnumDemo
    {
        enum colors { RED,GREEN,BLUE}; // declaring enum

        enum colors1 { RED=10, GREEN=20, BLUE=30 };

        enum days { Sun, Mon, Tue, Wed, Thu, Fri, Sat};

        public enum Emp { pacino, Spacey, Crowe, Pitt, Jolie };
        static void Main()
        {
            Console.WriteLine("Red :{0}", (int)colors.RED);
            Console.WriteLine("Red :{0}", (int)colors.GREEN);
            Console.WriteLine("Red :{0}", (int)colors.GREEN);

            Console.WriteLine("Red :{0}", (int)colors.RED);
            Console.WriteLine("Red :{0}", (int)colors.GREEN);
            Console.WriteLine("Red :{0}", (int)colors.GREEN);

            // traverse the enum using getValues()
            foreach(days d in Enum.GetValues(typeof(days)))
            {

                Console.WriteLine(d);
            }

            int count = 0;
            foreach (Emp e in Enum.GetValues(typeof(Emp)))
            {
                count++;
                Console.Write("Employee " + count + "...");
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
