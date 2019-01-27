using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            int i, num, n, troop = 0;
            int[] arrayname = new int[100];
            Console.WriteLine("enter the number of elements in your array");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("enetr the elements in the array");
            for (i = 0; i < num; i++)
                arrayname[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number to search");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < num; i++)
                if (arrayname[i] == n)
                {
                    Console.WriteLine($"the number {n}is present at location {i + 1}");
                    troop = 1;
                    break;

                }
            if (troop == 0)
                Console.WriteLine($"your number {n}is not present in the array ");
            Console.ReadKey();



        }
    }
}