using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class DeserializationDemo
    {
        static void Main()
        {
            string fpath = @" c:\\demo\\Serialize.txt";

            // Open the file Serialize.txt
            Stream s = File.Open(fpath, FileMode.Open);

            BinaryFormatter bf = new BinaryFormatter();

            //deserialize object
            UserDetails ud = (UserDetails)bf.Deserialize(s);
            s.Close();

            Console.WriteLine();
            Console.WriteLine("After Deserialization Object contains:");
            ud.GetDetails();
            Console.ReadKey();

        }
    }
}
