using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayprint
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, column, i, j;
            int[,] array2d = new int[10,10];
            Console.WriteLine("Enter the order of your matrix!!!");
            row = int.Parse(Console.ReadLine());
            column = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements of your matrix!!!");
            for(i=0;i<row;i++)
            {
                for(j=0;j<column;j++)
                {
                    array2d[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix is:");
            for (i=0;i<row;i++)
            {
                for (j=0;j<column;j++)
                {
                    Console.Write("{0}  ", array2d[i, j]);
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
