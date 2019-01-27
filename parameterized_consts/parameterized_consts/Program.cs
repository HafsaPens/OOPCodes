using System;
namespace parameterized_consts
{
    class Program
    { public int divide;
        static Program()
        {
            Console.WriteLine("PARAMETERIZED CONSTRUCTORS PROGRAM");
        }
        public Program(string name)
        {
            Console.WriteLine($"{name} has transacted money from ATM");
        }
        public Program(int a, int b)
        {
            divide = a / b; 
            Console.WriteLine($"division of two numbers gives {divide}");
        }
        public Program(char charcoal,int number)
        {
            Console.WriteLine($"The character chosen to display is {charcoal} and the number chosen is {number}");
        }
    }
    class flukey
    {
        static void Main()
        {
            Program const1 = new Program("Quartum Sonia");
            Program const2 = new Program(100, 10);
            Program const3 = new Program('%',220);
            Console.ReadKey();
        }
    }
}
