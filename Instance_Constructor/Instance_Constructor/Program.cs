using System;
namespace Instance_Constructor
{
    class Program
    {
        public int l, Area;
        public Program(int l)

        {
            Console.WriteLine("Area of square is {0}", l * l);
        }
    }
    class Candyfloss
    {
        static void Main()
        {
            Program obj = new Program(5);
            Program obj1 = new Program(10);
            Program obj2 = new Program(2);
            Console.ReadKey();

        }
    }

}
