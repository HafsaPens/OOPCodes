using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labjagged
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[][] jagged = new int[3][];
            //jagged[0] = new int[] { 4, 5, 6, 7 };
            //jagged[1] = new int[] { 3, 77, 9 };
            //jagged[2] = new int[] { 5, 8, 0 };
            //Console.WriteLine("\n The elements in the jagged array are:\n");
            //for(int i=0;i<jagged.Length;i++)
            //{
            // for(int j=0;j<jagged[i].Length;j++)
            //{
            //  Console.Write($"{jagged[i][j]}   ");
            //}
            //Console.WriteLine("\n");
            // }
            //Console.ReadKey();

            int[][] jagged = new int[5][];
            jagged[0] = new int[2];
            jagged[1] = new int[1];
            jagged[2] = new int[5];
            jagged[3] = new int[3];
            jagged[4] = new int[2];

          

            jagged[0][0]=33 ;
            jagged[0][1]= 44;
            jagged[1][0]= 55;
            jagged[2][0]= 66;
            jagged[2][1]= 77;
            jagged[2][2]= 88;
            jagged[2][3]= 99;
            jagged[2][4]= 00;
            jagged[3][0]= 12;
            jagged[3][1]= 13;
            jagged[3][2]= 14;
            jagged[2][0]= 15;
            jagged[2][1]= 16;
            Console.WriteLine("\n The number of elements in the jagged array are:\n");
            for(int i=0;i<jagged.Length;i++)
            {
                for(int j=0;j<jagged[i].Length;j++)
                {
                    Console.Write($"{jagged[i][j]}   ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();



        }
    }
}
