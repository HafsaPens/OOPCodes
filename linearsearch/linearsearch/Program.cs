using System;
namespace linearsearch
{
    class Program
    {
     
       static void Main()
        {
            int[] myarray = new int[100];
            int i, n, num,c=0;
        Console.WriteLine("Enter the number elements you wanna put in the array?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Now enter the elements of the array");
            for (i = 0; i < n; i++)
                myarray[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Array is");
            for (i = 0; i < n; i++)
                Console.WriteLine($"{myarray[i]}");
            Console.WriteLine("Enter the number you are searching for in the array?");
            num = int.Parse(Console.ReadLine());
            for(i=0;i<n;i++)
            {
                if (num == myarray[i])
                {
                    Console.WriteLine($"The number {num} is present at location {i}");
                    c = 1;
                    break;

                }

            }
            if (c==0)
                Console.WriteLine($"your number {num} is not present in the array");
            Console.ReadKey();
            
        }
        
        
    }
}
