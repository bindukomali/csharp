using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    class StudentDemo
    {
        static void Main()
        {
            Student s1 = new Student(101, "Mary");

            // s1.Name = "Steve";  /* Compiler Error because we are accessing read only
            //s1.Rollno = 100;        property*/

            s1.Course = "Computer Science";  // accessing write only property
            s1.City = "Bengaluru";     // store value in auto-implemented property

            Console.WriteLine(s1.Rollno + " " + s1.Name);
           // Console.WriteLine(s1.Course); // Compiler error - trying to access write only property

            s1.display();
            Console.WriteLine(s1.City);
            Console.ReadKey();
        }
    }
}
