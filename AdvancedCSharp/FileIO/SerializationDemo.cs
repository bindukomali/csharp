using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class SerializationDemo
    {
        static void Main()
        {
            UserDetails u1 = new UserDetails(777, "ENHYPEN", "Seoul");
            Console.WriteLine("Before Serialization object contains:  ");
            u1.GetDetails();



            string fpath = @" c:\\demo\\Serialize.txt";

            // Delete file if exists
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }



            // Open a file
            Stream s = File.Open(fpath, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();



            // Serialize the object into its  Binary Format
            bf.Serialize(s, u1);



            s.Close();
            Console.WriteLine("Serialization Successfull");
            Console.ReadKey();





        }
    }
}
