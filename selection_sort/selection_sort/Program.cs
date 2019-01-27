using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 44, 43, 66, 55, 54, 23, 34, 37, 76, 75, 55 };
            Console.WriteLine("\nThe array before Selection Sort is:\n");
            for(int i=0;i<=arr.Length-1;i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.WriteLine();
            for (int j = 0; j < arr.Length - 1; j++)
            {
                int min = j;
                for (int k = j + 1; k < arr.Length;k++)
                {
                    if(arr[min]>arr[k])
                    {
                        min = k;
                    }
                    
                }
                int temp = arr[min];
                arr[min] = arr[j];
                arr[j] = temp;

            }
            Console.WriteLine("\nThe array after Selection Sort is:\n");
            for(int i=0; i<=arr.Length-1;i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.ReadKey();

        }
    }
}
