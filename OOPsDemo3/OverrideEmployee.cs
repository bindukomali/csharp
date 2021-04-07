﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo3
{
    abstract class ClsEmployee
    {
        protected int EmpId, EAge;
        protected string EName, EAddress;
        public abstract void GetEmpData();



        protected ClsEmployee()
        {
            Console.WriteLine("Abstract Class Constructor");
        }
        public virtual void DisplayEmpData()
        {
            Console.WriteLine("Employee Id Is: " + this.EmpId);
            Console.WriteLine("Employee Name Is: " + this.EName);
            Console.WriteLine("Employee Address Is: " + EAddress);
            Console.WriteLine("Employee Age is: " + this.EAge);
        }
    }



    class Manager : ClsEmployee
    {
        double Bonus, CA;
        public override void GetEmpData()
        {
            Console.WriteLine("ENTER MANAGER DETAILS");
            Console.WriteLine("Enter the Manager Id: ");
            EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Manager name: ");
            EName = Console.ReadLine();
            Console.WriteLine("Enter the manager Bonus: ");
            Bonus = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Manager CA: ");
            CA = double.Parse(Console.ReadLine());
        }



        public override void DisplayEmpData()
        {
            Console.WriteLine("manager id is: " + EmpId);
            Console.WriteLine("manager name is: " + EName);
            Console.WriteLine("manager bonus is: " + Bonus);
            Console.WriteLine("Manager CA is: " + CA);
        }
    }
    class OverrideEmployee
    {
        static void Main()
        {
            Manager m1 = new Manager();
            m1.GetEmpData();
            m1.DisplayEmpData();
            Console.ReadKey();
        }
    }
}


