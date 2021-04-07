using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    // publisher class
    class Add
    {
        public delegate void dgOdd(); //Declare delegate
        public event dgOdd evOdd;   // declare event


        public void sum()
        {
            int result;
            result = 5 + 4;
            Console.WriteLine(result);
            // check if result is odd number then raise the event
            if((result % 2 !=0) && (evOdd !=null))
            {
                evOdd();   // Raise Event
            }
        }
    }

    //Subscriber class
    class EventsDemo
    {
        static void Main()
        {
            Add a = new Add();

            //Events gets binded with delegates
            a.evOdd += new Add.dgOdd(EventMessage);
            a.sum();
            Console.ReadKey();
        }

        //delegate calls this event handler when event raised
        private static void EventMessage()
        {
            Console.WriteLine(" Event Fired.. !! Result is  Odd Number");
        }
    }
}
