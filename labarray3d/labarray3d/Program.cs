using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labarray3d
{
    class Program
    {
        static void Main()
        {

       int[][] jagged = new int[3][];
        jagged[0] = new int[2];
         jagged[1] = new int[3];
         jagged[2] = new int[1];
            jagged[0][0] = 1;
            jagged[0][1] = 2;
            jagged[1][0] = 3;
            jagged[1][1] = 4;
            jagged[1][2] = 5;
            jagged[2][0] = 6;
            Console.WriteLine("\nThe jagged array is:\n");
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write($"{jagged[i][j]}   ");
                }
                Console.WriteLine("\n");
            }
                Console.ReadLine();
            }

    } }
