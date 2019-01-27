using System;

namespace my_static_constructor
{
    class Program
    {
        static int a;
        static string name;
        static bool b;
        static Program()
        
        {
            a = 1000;
            name = "Hafsa Iqbal";
            b = true;
        }
        class SKYSCRAPER
        {
            static void Main()
            {
                Program objname = new Program();
                Console.WriteLine($"a={a}");
                Console.WriteLine($"name is {name}");
                Console.WriteLine($"b={b}");
                Console.ReadKey();
            }
        }
    }
}
