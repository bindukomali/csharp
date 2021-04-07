using SalaryLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace MyAssemblyTest
{
    class Employee
    {
        int empId;
        string name;
        string desig;
        long basic;

        public int EmpId { get => empId; set => empId = value; }
        public string Name { get => name; set => name = value; }
        public string Desig { get => desig; set => desig = value; }
        public long Basic { get => basic; set => basic = value; }

        static void Main()
        {
            MySalary ms = new MySalary();

            Employee e1 = new Employee();

            e1.empId = 101;
            e1.Name = "John";
            e1.Desig = "Developer";
            e1.Basic = 10000;

            double netSal = ms.CalculateSal(e1.Basic);

            Console.WriteLine(e1.EmpId + " " + e1.Name + " " + e1.Desig + " "
                            + e1.Basic + " " + netSal);
            Console.ReadKey();
        }
    }
}

