using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 55, 3, 23, 4, 5, 6, 8, 34 };
            Console.WriteLine("The array before Bubble sorting is:\n");
            for(int i=0;i<=arr.Length-1;i++)
            {
                Console.Write("{0}  ",arr[i]);
                
            }

            //round specifies the number of comparisons left in the array!

            int round;
            for(round=1;round<=arr.Length-1;round++)
            {
                for(int j=0;j<=arr.Length-1-round;j++)
                {
                    if(arr[j]>arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;


                    }


                }
            }
            Console.WriteLine("\nThe array after Bubble sorting is:\n");
            for(int i=0;i<=arr.Length-1;i++)
            {
                Console.Write("{0}  ",arr[i]);
            }
            Console.ReadKey();

        }
    }
}
