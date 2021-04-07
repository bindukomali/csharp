using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class EventsDemo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Events Example****");
            Operations op = new Operations(10, 20);
            op.AddOperation();
            op.SubOperation();
            Console.ReadLine();

        }
    }
}
