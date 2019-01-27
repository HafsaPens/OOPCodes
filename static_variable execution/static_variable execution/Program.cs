using System;
namespace static_variable_execution
{
    class Program
    {
       public int vari=100;
       public Program()
        {
            Console.WriteLine("students' week");
            Console.WriteLine("{0}", vari);
        }
    }
    class tall
    {
        static void Main()
        {
            Program objname = new Program();
            Console.WriteLine("static variable is {0}", Program.vari);
            Console.ReadKey();
        }
    }
}
