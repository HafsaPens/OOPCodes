using System;
namespace aisayhi
{
    class Program
    {
        static int i;
        static Program()
        {
            i = 10;
         
        }
        static void Main()
        {
            Program objname = new Program();
            Console.WriteLine($"{objname.i}");

            Program objname1 = new Program();
            Console.WriteLine($"{objname1.i}");



                Console.ReadKey();
            
        }
    }
}