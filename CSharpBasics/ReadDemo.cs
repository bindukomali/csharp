using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class ReadDemo
    {
		public static void Main(string[] args)
		{
			int userInput;

			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
			Console.WriteLine();

			Console.Write("Input using Read() - ");
			userInput = Console.Read();
			Console.WriteLine("Ascii Value = {0}", userInput);
			Console.ReadKey();
		}
	}
}
