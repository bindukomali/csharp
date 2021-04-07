using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Address
    {
        public string street, city, state;

        public Address(string street, string city, string state)
        {
            this.street = street;
            this.city = city;
            this.state = state;
        }

    }

     class Pupil
    {
        int rollno;
        string name;
        static int batch = 2020;
        static string course = "B.tech";
        Address addr;   //  Aggregation --> has a relationship

        public Pupil(int rollno, string name, Address addr)
        {
            this.rollno = rollno;
            this.name = name;
            this.addr = addr;
        }

        public void display()
        {
            Console.WriteLine(rollno + " " + name + " " + addr.street + " " +
                 addr.city + " " + addr.state);
        }
    }
    class AggregationDemo
    {
        static void Main()
        {
            Address a1 = new Address("Indira Nagar", "Bengaluru", "Karnataka");
            Pupil p1 = new Pupil(101, "Mike", a1);
            p1.display();
            Console.ReadKey();
        }
    }
}
