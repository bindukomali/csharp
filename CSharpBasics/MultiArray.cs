using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class MultiArray
    {
        static void Main()
        {
            int[,] a = new int[3, 3];     // declaring multi dimension Array

            // intialisation
            a[0, 0] = 100;   // store 100 in 1 row, 1 column
            a[0, 1] = 200;
            a[0, 2] = 300;

            a[1, 1] = 200;
            a[2, 2] = 300;

            // traverse

            for(int i=0;i<3;i++)   // row index
            {
                for(int j=0;j<3;j++)   // col index
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] b = { { 11, 22, 33 }, { 1, 2, 3 }, { 99, 88, 77 } };

            // traverse
             for (int i = 0; i < 3; i++)   // row index
            {
                for (int j = 0; j < 3; j++)   // col index
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("The size of 2-d Array is" + b.Length);
            Console.WriteLine("Dimension of array is :" + b.Rank);

            int[,] c = new int[5, 10];
            Console.WriteLine("The numbers of rows:"+b.GetLength(0));
            Console.WriteLine("The numbers of cols:" + b.GetLength(1));
            Console.ReadKey();
        }
    }
}
