﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    class Employee
    {
        private int empId;
        private string empName;
        private string design;
        private decimal basic;
        private decimal hra;
        private decimal tax;
        private decimal da;
        private decimal netPay;
        private decimal grossPay;

        public Employee()
        {
            design = "Programmer";
            da = 2000;
        }

        public void input()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("Enter Employee Id & Name :");
            empId = Convert.ToInt32(Console.ReadLine());
            empName = Console.ReadLine();
            Console.WriteLine("Enter Basic Salary :");
            basic = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("======================================");

        }

        public decimal CalculateSalary()
        {
            hra = basic * (decimal).20;
            tax = basic * (decimal).10;
            grossPay = basic + hra + da;
            netPay = grossPay - tax;
            return netPay;
        }

        public void display()
        {

            Console.WriteLine("==================================");
            Console.WriteLine("Employee Details are : ");
            Console.WriteLine("Employee Id      : " + empId);
            Console.WriteLine("Employee Name    : " + empName);
            Console.WriteLine("Employee Desig   : " + design);
            Console.WriteLine("Employee Basic   : " + basic);
            Console.WriteLine("Employee HRA     : " + hra);
            Console.WriteLine("Employee DA      : " + da);
            Console.WriteLine("Gross Salary     : " + grossPay);
            Console.WriteLine("Tax deductions   : " + tax);
            Console.WriteLine("*********************************");
        }

    }

    
}
