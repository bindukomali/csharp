using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo3
{
    public partial class Employee500
    {
        int empId;
        string firstName;
        int age;

        public int EmpId { get => empId; set => empId = value; }

        public string FirstName { get => firstName; set => firstName = value; }

        public int Age { get => age; set => age = value; }

        partial void generateEmployeeId();   // declaring partial method

    }

    public partial class Employee500
    {
        partial void generateEmployeeId()
        {
            this.EmpId = 101;
        }

        public void input()
        {
            generateEmployeeId();
            this.FirstName = "Raj";
            this.Age = 30;
        }
    }
    class PartialMethodDemo1
    {
        static void Main()
        {
            Employee500 e = new Employee500();
            e.input();
            Console.WriteLine(e.EmpId + " " + e.FirstName + " " + e.Age);
            Console.ReadKey();
        }
    }
}
