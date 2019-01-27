using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Way_Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 5, 3, 66, 77, 33, 20 };
            Console.WriteLine("The array to apply Two Way Linear Search on is:\n");
            for(int i=0;i<=arr.Length-1;i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.WriteLine("\nEnter the value you want to search in the given array!!!\n");
            int value = int.Parse(Console.ReadLine());
            int start = 0, end = arr.Length - 1;
            bool flag = true;
            while(start<=end)
            {
              if(value==arr[start] || value==arr[end] && flag==true)
                {
                    Console.WriteLine("Your value {0} has been found!!!", value);
                    Console.ReadKey();
                    flag = false;
                }
                else
                {
                    start++;
                    end = end - 1;
                }
            }




        }
    }
}
