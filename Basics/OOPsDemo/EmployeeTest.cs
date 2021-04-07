using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    class EmployeeTest
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.input();
            decimal np = e1.CalculateSalary();
            e1.display();
            Console.WriteLine("Net Salary      : " + np);
            Console.WriteLine("======================================");
        }
    }
}
