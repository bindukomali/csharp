using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo3
{
    class Employee : IEmployee
    {
        int id;
        string name;
        public int empID { get {return id; } set {id = value; } }
        public string empname { get { return name; } set { name = value; } }
    }
}
