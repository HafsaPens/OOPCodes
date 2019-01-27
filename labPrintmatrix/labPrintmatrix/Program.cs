using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labPrintmatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, row, column;
            int[,] matrix = new int[100,100];
            Console.WriteLine("Enter the order of the 2D array\n");
            row = int.Parse(Console.ReadLine());
            column = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the elements of the matrix\n");
            for(i=0;i<row;i++)
            {
                for(j=0;j<column;j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                
                }
            }
            Console.WriteLine("\nThe matrix you entered is:\n");
            for(i=0;i<row;i++)
            {
               for(j=0;j<column;j++)
                {
                    Console.Write($"{matrix[i, j]}   ");
                    
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();

               
        }
    }
}
