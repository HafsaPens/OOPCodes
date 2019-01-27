using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter the element in the array!!!");
            for(int i=0;i<=6;i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine("\nThe array you entered is:\n");
            for(int i=0;i<=6;i++)
            {
                Console.Write("{0}  ", arr[i]);
             }
            Console.ReadKey();
            Console.WriteLine("\nEnter the value you want to search in the array!!!\n");
            int value = int.Parse(Console.ReadLine());
            for(int i=0;i<=arr.Length-1;i++)
            {
                if(value==arr[i])
                {
                    Console.WriteLine("\nThe value you entered has been found i.e {0}\n", arr[i]);
                    Console.ReadKey();
                    
                }
              
            }
        }
    }
}
