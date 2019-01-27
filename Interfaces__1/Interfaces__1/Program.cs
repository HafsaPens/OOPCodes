using System;
using System.Collections.Generic;
using System.Text;
using System.Object;


namespace Interfaces__1
{
    class Program
    {
        static void Main()
        {
            Star obj1 = new Star();
            square obj2 new square();
            string s1 = obj1.MakingPendants();
            string s2 = obj2.MakingPendants();
            Console.WriteLine("calling star class method", +s1);
            Console.WriteLine("Calling square class method", +s2);
            Console.ReadKey();
        }
    }
}
