using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 22, 32, 14, 55, 44, 26, 76, 56 };
            Console.WriteLine("\n The array before Insertion Sort is:\n");
            for(int i=0;i<=arr.Length-1;i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.WriteLine();
            for(int i=1;i<=arr.Length-1;i++)
            {
                int j = i;
                while(j>0 && arr[j]<arr[j-1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j--;
                }
            }
            Console.WriteLine("\nThe array after Insertion Sort is:\n");
            for(int i=0;i<arr.Length-1; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.ReadKey();
        }
    }
}
