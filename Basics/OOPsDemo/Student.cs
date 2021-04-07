using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Read Only / Write Only Properties */
namespace OOPsDemo
{
    class Student
    {
        private int rollno;
        private string name;
        private string course;
        private string city;
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }

        public int Rollno { get => rollno; }  /* read Only Property*/
        public string Name { get { return name; } }

        public string Course { set { course = value; } } /* Write Only property*/

        /* Auto Implemented properties; */
        public string City { get; set; }

        public void display()
        {
            Console.WriteLine(course);
        }
    }
}
