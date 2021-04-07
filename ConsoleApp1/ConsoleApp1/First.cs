using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class First
    {
       static void Main(String[] args)
        {
            int a, b, sum = 0;
            string name;
            decimal salary;
            double age;

            Console.WriteLine("My First Program in C#");
            Console.WriteLine("Enter ur Name, salary,age:");
            name = Console.ReadLine();
            salary = Convert.ToDecimal(Console.ReadLine());
            age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hello {0} with Age:{1} ur Salary is :{2}", name, age, salary);

            Console.WriteLine("Arithmetic Operations");
            Console.WriteLine("Enter 2 numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            sum = a + b;

            Console.WriteLine("The Addition of {0} and {1} is :{2}", a, b, sum);



        }
    }
}
