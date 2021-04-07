using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlJsonDemo
{
    class GenerateJson
    {

        static void Main()
        {
            Student s1 = new Student();

            s1.Rollno = 101;
            s1.Name = "John";
            s1.Courses = new List<string> { "Ajax", "C Sharp", "Java" };

            string jsonResult = JsonConvert.SerializeObject(s1);

            string path = @"c:\\demo\\student.json";

            using (var t = new StreamWriter(path, true))
            {
                t.WriteLine(jsonResult.ToString());
                t.Close();
            }
            Console.ReadKey();
        }
    }
}
