using System;
namespace staticinstance
{
    class Program
    {
        static int A;
        int B;
        static Program()
       
        {
            Console.WriteLine("Static constructor executed");
            A = 16;
        }
        public Program(int b)
        {
            Console.WriteLine("Instance constructor executed");
            B = b;
        }
        private void Display()
        {
            Console.WriteLine("A=" + A);
            Console.WriteLine("B=" + B);
        }
        static void Main()
        {
            Program P1 = new Program(20);
            P1.Display();
            Program P2 = new Program(30);
            P2.Display();
            
            Console.ReadKey();

        }
    }
}
