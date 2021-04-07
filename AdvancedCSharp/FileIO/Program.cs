using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class FileStreamDemo
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("c:\\demo\\abc.txt", FileMode.OpenOrCreate);
            Console.WriteLine("File Opened");

            f.WriteByte(70);
            Console.WriteLine("Data Written into File");
            f.Close();

            FileStream f1 = new FileStream("c:\\demo\\abc.txt", FileMode.OpenOrCreate);
            char a = (char)f1.ReadByte();
            Console.WriteLine("Data read from file is :" + a);
            f1.Close();
            Console.WriteLine("File Stream closed");

            Console.ReadKey();

        }
    }
}
