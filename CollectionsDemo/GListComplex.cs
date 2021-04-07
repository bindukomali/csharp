using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class GListComplex
    {
        static void Main()
        {
            // Create Employee Objects
            Employee emp1 = new Employee()
            {
                Id = 101,
                Name = "Raj",
                Gender = "Male",
                Salary = 5000
            };
            Employee emp2 = new Employee()
            {
                Id = 102,
                Name = "Mary",
                Gender = "Female",
                Salary = 7000
            };
            Employee emp3 = new Employee()
            {
                Id = 103,
                Name = "Mike",
                Gender = "Male",
                Salary = 5500
            };
            Employee emp4 = new Employee()
            {
                Id = 104,
                Name = "Ravi",
                Gender = "Male",
                Salary = 6500
            };

            List<Employee> listEmployees = new List<Employee>();

            listEmployees.Add(emp1);
            listEmployees.Add(emp2);
            listEmployees.Add(emp3);

            Console.WriteLine("************************ Employees List **********************");
            foreach(Employee e in listEmployees)
            {
                Console.WriteLine(e.Id + " " + e.Name + "  " + e.Gender + " " + e.Salary);
            }
            Console.WriteLine();
            Employee emp = listEmployees[0];

            Console.WriteLine("Retrive the First employee by index");
            Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}",
                     emp.Id, emp.Name, emp.Gender, emp.Salary);
            Console.WriteLine();

            // inserting employee to index pos 1
            listEmployees.Insert(1, emp4);

            Console.WriteLine("******************* Display New List ********************");
            for(int i=0;i<listEmployees.Count;i++)
            {
                Employee em = listEmployees[i];
                Console.WriteLine(em.Id + " " + em.Name + " "+ em.Gender + " " + em.Salary);
            }
            Console.ReadKey();
        }
    }
}
