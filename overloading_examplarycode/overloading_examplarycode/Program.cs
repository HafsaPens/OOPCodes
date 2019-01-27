using System;
namespace overloading_examplarycode
{
    class fantum
    {
        int result;
        double addition;
        int area_of_square;
        public fantum()
        {
            Console.WriteLine("Overloading of methods");
        }
        public void Mathematics(int num1,int num2,int num3)
        {
            result = num1 * num2 * num3;
            Console.WriteLine($"multiplication of three numbers gives {result} ");

        }
        public void Mathematics(double a,double b)
        {
            addition = a + b;
            Console.WriteLine($"addition of two numbers gives {addition}");
        }
        public void Mathematics(int x)
        {
            area_of_square = x * x;
            Console.WriteLine($"area of square is {area_of_square}");
        }
    }
    class Program
    { 
        static void Main()
        {
            fantum ft = new fantum();
            ft.Mathematics(10, 50, 40);
            ft.Mathematics(5);
            ft.Mathematics(10.3, 20.3);
            Console.ReadKey();
        }
    }
}
