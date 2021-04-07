using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    // publisher class
    class Math
    {
        // declare delegate
        public delegate void SampleDelegate();
        //Declare event
        public event SampleDelegate SampleEvent;

        public void Add(int a, int b)
        {

            // Calling event delegate to check subscription

            if (SampleEvent != null)
            {
                // Raise the event by using () operator
                SampleEvent();
                Console.WriteLine("Add Result: {0}", a + b);
            }

            else
            {
                Console.WriteLine("Not Subscribed to Event");
            }

        }

        public void Subtract(int x, int y)
        {
            // Calling event delegate to check subscription

            if (SampleEvent != null)
            {

                // Raise the event by using () operator

                SampleEvent();

                Console.WriteLine("Subtract Result: {0}", x - y);
            }

            else

            {

                Console.WriteLine("Not Subscribed to Event");

            }

        }
    }
}
