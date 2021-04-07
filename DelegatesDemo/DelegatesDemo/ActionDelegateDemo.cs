using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class ActionDelegateDemo
    {
        public static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
        static void Main()
        {
            Action<int> a = ConsolePrint;   // 1st way

            Action<int> b = new Action<int>(ConsolePrint);

            a.Invoke(100);

            b(20);
        }
    }
}
