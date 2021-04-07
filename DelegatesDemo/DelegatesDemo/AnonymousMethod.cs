using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    // step1 - Defining Delegate
    public delegate double RectDelegate(double width, double height);
    class AnonymousMethod
    {
        static void Main()
        {
            // step2 -  Instantiating the delegate using anonymous method

            RectDelegate r1 = delegate (double width, double height)
            { return width * height; };

            // Step3- Invoking delegate
            Console.WriteLine("Area of Rectangle is :{0}", r1.Invoke(10.10, 20.10));
        }

    }
}
