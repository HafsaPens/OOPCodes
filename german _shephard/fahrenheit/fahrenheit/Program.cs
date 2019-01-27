using System;
namespace fahrenheit
{
    class Program
    {
        static void Main()
        {
            double celsius, fahrenheit;
            Console.WriteLine("Enter temperature in Celsius?");
            celsius = double.Parse(Console.ReadLine());
            fahrenheit = 1.8*(celsius + 32);
            Console.WriteLine("Fahrenheit temperature is {0}", fahrenheit);
            Console.ReadKey();

        }
    }
}
