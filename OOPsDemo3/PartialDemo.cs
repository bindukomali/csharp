using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo3
{
    class PartialDemo
    {
        static void Main()
        {
            PartialEmployee emp = new PartialEmployee();

            emp.FirstName = "Raj";
            emp.LastName = "gs";
            emp.Salary = 100000;
            emp.Gender = "Male";
            emp.DisplayFullName();
            emp.DisplayEmployeeDetails();
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();

        }
    }
}
