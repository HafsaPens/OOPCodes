using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,2,3,4,5,6,7,8,9};
            Console.WriteLine("The array is:\n");
            for(int i=0;i<=arr.Length-1;i++)
            {
                Console.Write("{0}  ",arr[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Enter the value you want to search in the array!!!");
            int value = int.Parse(Console.ReadLine());
            int start = 0, end = arr.Length;
            bool flag = true;
            while(start<=end)
            { 
                int mid = (start + end) / 2;
                  if (value==arr[mid]&& flag==true)
                {
                    Console.WriteLine("Value has been found! i.e {0}",arr[mid]);
                    flag = false;
                    Console.ReadKey();
                    break;

                    
                  
                }
                else if (value > arr[mid])
                {

                    start = mid + 1;
                }
                else if(value<arr[mid])
                {
                    end = mid - 1;
                }
                

            }
           
        }
    }
}
