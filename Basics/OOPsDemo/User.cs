using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    class User
    {
        private String name;
        private String location;

        private string desig;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }

        public string Desig { get { return desig.ToUpper(); }  set { desig = value; } }

        public int Age { get { return age; } set { if (value > 20) age = value; } }

        public static void Main()
        {
            User u = new User();
            u.Name = "Steven";
            u.Location = "Bengaluru";

            u.Desig = "Developer";
            u.Age = 18;

            Console.WriteLine(u.Name + " - " + u.Location);
            Console.WriteLine(u.Desig + " - " + u.Age);

           Console.ReadKey();
        }
    }
}
